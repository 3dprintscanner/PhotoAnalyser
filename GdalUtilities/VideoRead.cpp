#include "stdafx.h"
#include "opencv2/opencv.hpp"
#include "opencv2/core.hpp"


using namespace cv;
using namespace std;

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

int videoCamera(){

	VideoCapture capture(0);

	if (!capture.isOpened()) return 1;

	bool finish = false;

	Mat frame;

	Mat prev_frame;

	namedWindow("Video Camera");

	if (!capture.read(prev_frame)) return 1;

	cvtColor(prev_frame, prev_frame, COLOR_BGR2GRAY);

	while (!finish){
		if (!capture.read(frame)) return 1;
		cvtColor(frame, frame, COLOR_BGR2GRAY);


		//maxMovementLK(prev_frame, frame);

		Rect search_window(200, 150, 100, 100);
		trackingMeanShift(frame, search_window);
		//trackingCamShift(frame, search_window);

		imshow("Video Camera", frame);

		if (waitKey(1) == 27) finish = true;

		prev_frame = frame;
	}

	capture.release();
	return 0;

}




int main(int argc, const char * argv[]){
	videoCamera();
}


