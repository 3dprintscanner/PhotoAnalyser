#include "stdafx.h"
#include "ImageBlend.h"
#include "opencv2/opencv.hpp"
#include "opencv2/imgproc/imgproc.hpp"
#include "opencv2/highgui/highgui.hpp"


using namespace cv;
using namespace std;
//RetinaFilter::RetinaFilter()
//{
//}
//
//
//RetinaFilter::~RetinaFilter()
//{
//}


//int main(int argc, char* argv[])
//{
//	Mat src, src2, dst;
//	double alpha = 0.5, beta, input;
//	src = imread("C:\\Users\\anthony\\Pictures\\Photo0069.jpg");
//		
//	if (src.empty())
//	{
//		std::cout << "Could not read image" << endl;
//		return -1;
//	}
//
//	src2 = imread("C:\\Users\\anthony\\Pictures\\Photo0032.jpg");
//
//	if (src.empty())
//	{
//		std::cout << "Could not read second image" << endl;
//		return -1;
//	}
//		
//	namedWindow("Final Linear Blend", WINDOW_AUTOSIZE);
//
//	for (int i = 0; i <= 100; ++i)
//	{
//		alpha = (double)(i) / 100;
//
//		beta = 1 - alpha;
//
//		addWeighted(src2, alpha, src, beta, 0.0, dst);
//
//		imshow("Final Linear Blend", dst);
//		cvWaitKey(50);
//
//	}
//
//	namedWindow("Original image 1", CV_WINDOW_AUTOSIZE);
//	namedWindow("Original image 2", CV_WINDOW_AUTOSIZE);
//
//	imshow("Original image 1", src);
//	imshow("Original image 2", src2);
//
//	cvWaitKey();
//	return 0;
//}
//
//
