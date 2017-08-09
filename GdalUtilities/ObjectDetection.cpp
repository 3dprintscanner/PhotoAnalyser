#include "stdafx.h"
#include "ObjectDetection.h"
#include "opencv2/highgui/highgui.hpp"
#include "opencv2/dpm.hpp"
#include "opencv2/objdetect/objdetect.hpp"
#include "opencv2/imgproc/imgproc.hpp"
#include <iostream>

ObjectDetection::ObjectDetection()
{
}


ObjectDetection::~ObjectDetection()
{
}

using namespace cv;
using namespace std;
using namespace dpm;

void detectAndDisplay(Mat frame);

Mat detectFrame(Mat frame);

String face_cascade_name = "C:\\Users\\anthony\\\opencv\\data\\haarcascades\\haarcascade_frontalface_default.xml";
String eyes_cascade_name = "C:\\Users\\anthony\\\opencv\\data\\haarcascades\\haarcascade_eye.xml";

CascadeClassifier face_classifier, eyes_classifier;

int main(int argc, char* argv[])
{
	String model = argv[1];

	VideoCapture capture;

	Mat frame, output_frame;

	
	namedWindow("Face", WINDOW_AUTOSIZE);
	namedWindow("Video", WINDOW_AUTOSIZE);
	

	if (!eyes_classifier.load(eyes_cascade_name))
	{
		cout << "Eyes classifier not loaded" << endl;
		waitKey(0);
		return -1;
	}
	printf("Eyes Loaded\n");
	if (!face_classifier.load(face_cascade_name))
	{
		cout << "Face classifier not loaded" << endl;
		waitKey(0);
		return -1;
	} 
	printf("Face Loaded\n");

	capture.open(0);
	if (!capture.isOpened())
	{
		cout << "Failed to open Video Stream" << endl;
		return -1;
	}
	//int fps = capture.get(CV_CAP_PROP_FPS);

	while (capture.read(frame))
	{
		if (frame.empty())
		{
			printf("No frame data");
			break;
		}

		//imshow("Video", frame);

		detectAndDisplay(frame);

		if (waitKey(1000 / 24) == 0){
			break;
		}
	}
	/*capture.read(frame);
	detectAndDisplay(frame);*/

	// seems to work, lower the sampling rate for image processing
	//imwrite("C:\\test\\testdetect.jpg", frame);
	//imshow("Face", );
	waitKey(0);
	capture.release();
	return 0;
}



void detectAndDisplay(Mat frame)
{
	vector<Rect> faces;

	Mat frame_gray;
	imshow("Face", frame);

	cvtColor(frame, frame_gray, COLOR_BGR2GRAY);

	equalizeHist(frame_gray, frame_gray);

	face_classifier.detectMultiScale(frame_gray, faces, 1.1, 2, 0 | CASCADE_SCALE_IMAGE, Size(30, 30));

	for (size_t i = 0; i < faces.size(); i++)
	{
		Point center(faces[i].x + faces[i].width / 2, faces[i].y + faces[i].height / 2);

		ellipse(frame, center, Size(faces[i].width / 2, faces[i].height / 2), 0, 0, 360, Scalar(0, 255, 0), 4, 8, 0);

		Mat frameRoiMask = frame_gray(faces[i]);

		// create an image of the face and use that to mask the search zone to only detect eyes within the face


		vector<Rect> eyes;

		eyes_classifier.detectMultiScale(frameRoiMask, eyes, 1.1, 2, 0 | CASCADE_SCALE_IMAGE, Size(30, 30));

		for (size_t j = 0; j < eyes.size(); j++)
		{
			
			Point centereye(faces[i].x + eyes[j].x + eyes[j].width / 2, faces[i].y + eyes[j].y + eyes[j].height / 2);
			//Point centereye(eyes[j].x + eyes[j].width / 2, eyes[j].y + eyes[j].height / 2);
			

			int radius = cvRound((eyes[j].width + eyes[j].height)*0.25);
			circle(frame, centereye,radius,Scalar(255,0,0),4,8,0);
		}

	}
	imshow("Face", frame);


}
