#include "stdafx.h"
#include "CascadeDetection.h"
#include "opencv2/core/core.hpp"
#include "opencv2/highgui/highgui.hpp"
#include "opencv2/objdetect/objdetect.hpp"
#include "opencv2/imgproc/imgproc.hpp"
#include "iostream"

CascadeDetection::CascadeDetection()
{
}


CascadeDetection::~CascadeDetection()
{
}

using namespace cv;
using namespace std;


int main(int argc, char* argv[])
{
	

	//CascadeClassifier cascade("C:\\Users\\anthony\\opencv\\data\\hogcascades\\hogcascade_pedestrians.xml");

	HOGDescriptor cascade;

	cascade.setSVMDetector(HOGDescriptor::getDefaultPeopleDetector());

	
	/*if (cascade == nullptr)
	{
		cout << "Cascade Not Initialized" << endl;
		return -1;
	}*/

	//VideoCapture vid(argv[2]);

	VideoCapture vid("C:\\Users\\anthony\\opencv\\samples\\data\\768x576.avi");

	if (!vid.isOpened())
	{
		cout << "Could not open video" << endl;
		return -1;

	}

	namedWindow("Pedestrian Detection");

	Mat frame;

	while (1)
	{
		if (!vid.read(frame))
		{
			break;
		}

		Mat frame_gray;

		if (frame.channels() > 1)
		{
			cvtColor(frame, frame_gray, CV_BGR2GRAY);
			equalizeHist(frame_gray, frame_gray);

		} else
		{
			frame_gray = frame;
		}

		vector<Rect> pedestrians;
		vector<double> weights;

		//cascade.detectMultiScale(frame_gray, pedestrians, 1.1, 2, 0, Size(30, 30), Size(150, 150));

		cascade.detectMultiScale(frame_gray, pedestrians,weights,0,Size(8,8),Size(32,32),1.05,2);

		for (size_t i = 0; i < pedestrians.size(); ++i)
		{
			Point center(pedestrians[i].x + pedestrians[i].width * 0.5, pedestrians[i].y + pedestrians[i].height* 0.5);

			ellipse(frame, center, Size(pedestrians[i].width*0.5, pedestrians[i].height*0.5), 0, 0, 360, Scalar(255, 0, 255), 4, 8, 0);

		}

		imshow("Pedestrian Detection", frame);

		if (waitKey(100) >= 0) break;
	}
	return 0;
}
