#include "stdafx.h"
#include "Histogram.h"

#include <opencv2/imgproc/imgproc.hpp>/
#include <opencv2/highgui/highgui.hpp>
#include<iostream>


//Histogram::Histogram()
//{
//}
//
//
//Histogram::~Histogram()
//{
//}

#define SOURCE_WIN "Source"
#define GRAY_WIN "Gray level image"
#define HISTO_IMAGE "Histogram"
#define EQ_HISTO_IMAGE "Equalized Histogram"

using namespace cv;
using namespace std;

//int main(int argc, char* argv[])
//{
//	int histSize = 255;
//	long int dim;
//	Mat hist, image;
//
//	if (argc != 2)
//	{
//		cout << "Invoke with image path" << endl;
//		return -1;
//	}
//
//	Mat src = imread(argv[1]);
//
//
//	if (src.empty())
//	{
//		cout << "Image Could Not be loaded" << endl;
//		return -1;
//	}
//
//	cvtColor(src, image, CV_RGB2GRAY);
//
//	namedWindow(SOURCE_WIN, WINDOW_AUTOSIZE);
//	namedWindow(GRAY_WIN, WINDOW_AUTOSIZE);
//	namedWindow(HISTO_IMAGE, WINDOW_AUTOSIZE);
//
//	imshow(SOURCE_WIN, src);
//	imshow(GRAY_WIN, image);
//
//	calcHist(&image, 1, nullptr, Mat(), hist, 1, &histSize, nullptr);
//
//	dim = image.rows * image.cols;
//
//	Mat histImage = Mat::ones(255, 255, CV_8U) * 255;
//
//	normalize(hist, hist, 0, histImage.rows, CV_MINMAX, CV_32F);
//
//	histImage = Scalar::all(255);
//
//	int binW = cvRound((double)histImage.cols / histSize);
//
//	for (int i = 0; i < histSize; i++)
//	{
//		rectangle(histImage, Point(i*binW, histImage.rows), Point((i + 1)*binW, histImage.rows - cvRound(hist.at<float>(i))), Scalar::all(0), -1, 8, 0);
//		imshow(HISTO_IMAGE, histImage);
//
//	};
//
//	cout << "Press Any Key to Exit" << endl;
//
//	waitKey();
//
//	return 0;
//
//}



//int main(int argc, char* argv[])
//{
//	int histSize = 255;
//	long int dim;
//	Mat hist, image;
//
//	if (argc != 2)
//	{
//		cout << "Invoke with image path" << endl;
//		return -1;
//	}
//
//	Mat src = imread(argv[1]);
//
//
//	if (src.empty())
//	{
//		cout << "Image Could Not be loaded" << endl;
//		return -1;
//	}
//
//	cvtColor(src, src, CV_RGB2GRAY);
//	equalizeHist(src, image);
//
//
//	namedWindow(SOURCE_WIN, WINDOW_AUTOSIZE);
//	namedWindow(GRAY_WIN, WINDOW_AUTOSIZE);
//	namedWindow(EQ_HISTO_IMAGE, WINDOW_AUTOSIZE);
//
//	imshow(SOURCE_WIN, src);
//	imshow(GRAY_WIN, image);
//
//	calcHist(&image, 1, nullptr, Mat(), hist, 1, &histSize, nullptr);
//
//	dim = image.rows * image.cols;
//
//	Mat histImage = Mat::ones(255, 255, CV_8U) * 255;
//
//	normalize(hist, hist, 0, histImage.rows, CV_MINMAX, CV_32F);
//
//	histImage = Scalar::all(255);
//
//	int binW = cvRound((double)histImage.cols / histSize);
//
//	for (int i = 0; i < histSize; i++)
//	{
//		rectangle(histImage, Point(i*binW, histImage.rows), Point((i + 1)*binW, histImage.rows - cvRound(hist.at<float>(i))), Scalar::all(0), -1, 8, 0);
//		imshow(EQ_HISTO_IMAGE, histImage);
//
//	};
//
//	cout << "Press Any Key to Exit" << endl;
//
//	waitKey();
//
//	return 0;
//
//}
