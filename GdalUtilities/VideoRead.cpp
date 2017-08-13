#include "stdafx.h"
#include "opencv2/opencv.hpp"
#include "opencv2/core.hpp"
#include "opencv2/tracking.hpp"
#include "opencv2/imgproc.hpp"
#include "opencv2/optflow/motempl.hpp"
#include "opencv2/ml/ml.hpp"
#include <ctime>
#include <vector>

using namespace cv;
using namespace std;
using namespace ml;


clock_t INITIAL_TIME;

void maxMovementLK(Mat& prev_frame, Mat& frame){
	vector<Point2f> initial_features;

	goodFeaturesToTrack(prev_frame, initial_features, CV_HARDWARE_MAX_FEATURE, 0.1, 0.2);

	vector<Point2f> new_features;
	vector<uchar> status;
	vector<float> err;

	TermCriteria criteria(TermCriteria::COUNT | TermCriteria::EPS, 20, 0.03);

	Size window(10, 10);

	int max_level = 3;

	int flags = 0;

	double min_eigT = 0.004;

	calcOpticalFlowPyrLK(prev_frame, frame, initial_features, new_features, status, err, window, max_level, criteria, flags, min_eigT);

	double max_move = 0;
	double movement = 0;

	for (int i = 0; i < initial_features.size(); i++)
	{
		Point pointA(initial_features[i].x, initial_features[i].y);

		Point pointB(new_features[i].x, new_features[i].y);

		line(prev_frame, pointA, pointB, Scalar(255, 0, 0), 2);

		movement = norm(pointA - pointB);
		if (movement > max_move){
			max_move = movement;
		}


	}

	if (max_move > 100){
		putText(prev_frame, "INTRUDER", Point(100, 100), FONT_ITALIC, 3, Scalar(255, 0, 0), 5);
		imshow("Video Camera", prev_frame);
		cout << "Press a Key to continue" << endl;

		waitKey();

	}




}


void trackingMeanShift(Mat& img, Rect search_window){


	TermCriteria criteria(TermCriteria::COUNT | TermCriteria::EPS, 10,1);

	meanShift(img, search_window, criteria);
	rectangle(img, search_window, Scalar(0, 255, 0), 3);

}

void trackingCamShift(Mat& img, Rect search_window){
	TermCriteria criteria(TermCriteria::COUNT | TermCriteria::EPS, 10, 1);

	RotatedRect found_object = CamShift(img, search_window, criteria);

	Rect found_rect = found_object.boundingRect();

	rectangle(img, found_rect, Scalar(0, 255, 0), 3);
}

//
//void updateMotionHistoryTemplate(Mat& prev_frame, Mat& frame, Mat& history){
//	
//	absdiff(prev_frame, prev_frame, prev_frame);
//
//	double threshold_val = 100;
//	threshold(prev_frame, prev_frame, threshold_val, 255, THRESH_BINARY);
//
//	clock_t aux_time = clock();
//
//	double current_time = (aux_time - INITIAL_TIME) / CLOCKS_PER_SEC;
//
//	updateMotionHistory(prev_frame, history, current_time, 100);
//}




// background subtraction technique


int backGroundSubKNN(){
	Mat frame, background, foreground;

	bool finish = false;

	int history = 200;


	double dist2threshold = 400.0;

	bool detectShadows = false;
	vector<vector<Point>> contours;

	namedWindow("Frame");
	namedWindow("Background");

	VideoCapture capture(0);

	if (!capture.isOpened()) return 1;

	Ptr<BackgroundSubtractorKNN> bgKnn = createBackgroundSubtractorKNN(history, dist2threshold, detectShadows);

	while (!finish){
		if (!capture.read(frame)) return 1;

		bgKnn->apply(frame, foreground);
		bgKnn->getBackgroundImage(background);


		erode(foreground, foreground, Mat());
		dilate(foreground, foreground, Mat());

		findContours(foreground, contours, RETR_EXTERNAL, CHAIN_APPROX_NONE);
		drawContours(frame, contours, -1, Scalar(0, 2, 255), 2);

		imshow("Frame", frame);
		imshow("Background", background);

		moveWindow("Frame", 0, 100);
		moveWindow("Background", 800, 100);

		if (waitKey(1) == 27) finish = true;
	}
	capture.release();
	return 0;
}
// warp the image to recocile change of camera alignment.

// keep a constant perspective of an image
int findCameraMovement(){
	bool finish = false;

	Mat frame, initial_frame, warp_matrix, warped_frame;

	int warp_mode = MOTION_HOMOGRAPHY;

	TermCriteria criteria(TermCriteria::COUNT | TermCriteria::EPS, 50, 0.001);

	VideoCapture capture(0);

	Rect rec(100, 50, 350, 350);
	Mat aux_initial_frame;

	bool follow = false;

	if (!capture.isOpened()) return 1;

	cout << "Press c to continue" << endl;

	while (!follow){
		if (!capture.read(initial_frame)) return 1;

		cvtColor(initial_frame, initial_frame, COLOR_BGR2GRAY);

		aux_initial_frame = initial_frame.clone();

		rectangle(aux_initial_frame, rec, Scalar(255, 255, 255), 3);
		imshow("Initial Frame", aux_initial_frame);

		if (waitKey(1) == 99) follow = true;
	}

	Mat template_frame(rec.width, rec.height,CV_32F);

	template_frame = initial_frame.colRange(rec.x, rec.x + rec.width).rowRange(rec.y, rec.y + rec.height);

	imshow("Template image", template_frame);

	while (!finish){
		cout << "Press a key to continue" << endl;

		waitKey();

		warp_matrix = Mat::eye(3, 3, CV_32F);

		if (!capture.read(frame)) return 1;

		cvtColor(frame, frame, COLOR_BGR2GRAY);

		try{
			findTransformECC(template_frame, frame, warp_matrix, warp_mode, criteria);

			warped_frame = Mat(template_frame.rows,template_frame.cols, CV_32F);

			warpPerspective(frame, warped_frame, warp_matrix, warped_frame.size(), WARP_INVERSE_MAP + WARP_FILL_OUTLIERS);
			

		}
		catch (Exception e){
			cout << "Exception " << e.err << endl;
		}

		imshow("Frame", frame);
		imshow("Warped Frame", warped_frame);

		if (waitKey(1) == 27) finish = true;
	}

	capture.release();
	return 0;


}

int videoCamera(){

	VideoCapture capture(0);

	if (!capture.isOpened()) return 1;

	bool finish = false;

	Mat frame,prev_frame;
	INITIAL_TIME = clock() / CLOCKS_PER_SEC;

	namedWindow("Video Camera");

	if (!capture.read(prev_frame)) return 1;

	cvtColor(prev_frame, prev_frame, COLOR_BGR2GRAY);

	Mat history(prev_frame.rows, prev_frame.cols, CV_32FC1);

	while (!finish){
		if (!capture.read(frame)) return 1;
		cvtColor(frame, frame, COLOR_BGR2GRAY);


		//maxMovementLK(prev_frame, frame);

		Rect search_window(200, 150, 100, 100);
		//trackingMeanShift(frame, search_window);
		//trackingCamShift(frame, search_window);
		//updateMotionHistoryTemplate(prev_frame, frame, history);

		imshow("Video Camera", frame);

		imshow("History", history);

		if (waitKey(1) == 27) finish = true;

		prev_frame = frame;
	}

	capture.release();
	return 0;

}


int doKNN(){
	Mat classes(5 , 1, CV_32FC1);
	Mat colours(5 , 3, CV_32FC1);

	colours.at<float>(0, 0) = 0;
	colours.at<float>(0, 1) = 0;
	colours.at<float>(0, 2) = 0;
	colours.at<float>(1, 0) = 255;
	colours.at<float>(1, 1) = 255;
	colours.at<float>(1, 2) = 255;
	colours.at<float>(2, 0) = 255;
	colours.at<float>(2, 1) = 0;
	colours.at<float>(2, 2) = 0;
	colours.at<float>(3, 0) = 0;
	colours.at<float>(3, 1) = 255;
	colours.at<float>(3, 2) = 0;


	classes.at<float>(0, 0) = 1;
	classes.at<float>(1, 0) = 2;
	classes.at<float>(2, 0) = 3;
	classes.at<float>(3, 0) = 4;
	classes.at<float>(4, 0) = 5;

	Ptr<KNearest> classifier = KNearest::create();

	Ptr<TrainData> data = TrainData::create(colours, ROW_SAMPLE, classes);

	classifier->train(data);

	Mat src = imread("C:\\Users\\anthony\\opencv\\samples\\data\\baboon.jpg",CV_LOAD_IMAGE_COLOR);

	imshow("baboon", src);

	Mat dst(src.rows, src.cols, CV_8UC3);


	// response for each pixel
	Mat results;

	Mat newPoint(1, 3, CV_32FC1);

	float prediction = 0;

	for (int y = 0; y < src.rows; y++)
	{
		for (int x = 0; x < src.cols; x++)
		{
			newPoint.at<float>(0, 0) = src.at<Vec3b>(y, x)[0];
			newPoint.at<float>(0, 1) = src.at<Vec3b>(y, x)[1];
			newPoint.at<float>(0, 2) = src.at<Vec3b>(y, x)[2];


			prediction = classifier->findNearest(newPoint, 1, results);

			dst.at<Vec3b>(y, x)[0] = colours.at <float>(prediction - 1, 0);
			dst.at<Vec3b>(y, x)[1] = colours.at <float>(prediction - 1, 1);
			dst.at<Vec3b>(y, x)[2] = colours.at <float>(prediction - 1, 2);


		}
	}

	imshow("Result KNN", dst);
	waitKey(0);
	return 0;

}

int main(int argc, const char * argv[]){
	//videoCamera();
	//backGroundSubKNN();
	//findCameraMovement();
	doKNN();
}
