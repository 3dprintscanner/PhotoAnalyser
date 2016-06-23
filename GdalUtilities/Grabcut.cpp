#include "stdafx.h"
#include "Grabcut.h"
#include "opencv2/opencv.hpp"
#include "iostream"

Grabcut::Grabcut()
{
}


Grabcut::~Grabcut()
{
}


using namespace std;
using namespace cv;

//int main(int argc, char* argv[])
//{
//	Mat src = imread("stuff.jpg");
//	Mat tgt = src.clone();
//
//	imshow("Source", src);
//
//	// Grabcut seg.
//
//	Rect rectangle(180, 279, 60, 60);
//
//	Mat result, bgModel, fgModel;
//
//	grabCut(src, result, rectangle, bgModel, fgModel, 1, GC_INIT_WITH_RECT);
//
//	result = result & GC_FGD;
//
//	Mat aff = Mat::eye(2, 3, CV_32FC1);
//
//	aff.at<float>(0, 2) = 50;
//
//	warpAffine(tgt, src, aff, result.size());
//	warpAffine(result, result, aff, result.size());
//
//	src.copyTo(tgt, result);
//
//	imshow("Target", tgt);
//
//	cout << "Press any key to exit" << endl;
//
//	waitKey();
//
//	return 0;
//}
