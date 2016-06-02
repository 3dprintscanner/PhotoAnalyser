#include "stdafx.h"
#include "Contrast.h"


//Contrast::Contrast()
//{
//}
//
//
//Contrast::~Contrast()
//{
//}


//#include <opencv2/imgproc/imgproc.hpp>/
//#include <opencv2/highgui/highgui.hpp>
//#include<iostream>
//
//using namespace cv;
//using namespace std;
//
//int init_brightness = 100;
//int init_contrast = 100;
//
//Mat image;
//
//void update_brightness_and_contrast(int, void*)
//{
//	int histSize = 255;
//
//	int var_brightness = init_brightness - 100;
//	int var_contrast = init_contrast - 100;
//
//	double a, b;
//
//	if (var_contrast > 0)
//	{
//		double delta = 127.*var_contrast / 100;
//		a = 255. / (255 - delta * 2);
//		b = a*(var_brightness - delta);
//
//	}
//	else
//	{
//		double delta = -128.*var_contrast / 100;
//		a = (256. - delta * 2) / 255;
//		b = a*var_brightness + delta;
//	}
//
//	Mat dst, hist;
//
//	image.convertTo(dst, CV_8U, a, b);
//
//	imshow("image", dst);
//
//	calcHist(&dst, 1, 0, Mat(), hist, 1, &histSize, 0);
//
//	Mat histImage = Mat::ones(200, 320, CV_8U) * 255;
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
//		imshow("histogram", histImage);
//
//	};
//
//}
//
//const char* keys = {
//	"{1| |C:\\Users\\anthony\\Pictures\\Photo0049.jpg| input image file}"
//};
//
//
//int main(int argc, char* argv[])
//{
//	CommandLineParser parser(argc, argv, keys);
//	//string inputImage = parser.get<string>("1");
//	string inputImage = "C:\\Users\\anthony\\Pictures\\Photo0049.jpg";
//	image = imread(inputImage, 0);
//
//	if (image.empty())
//	{
//		cout << "Image Could Not be read" << endl;
//		return -1;
//	}
//
//	namedWindow("image", 0);
//	namedWindow("histogram", 0);
//
//	createTrackbar("brightness", "image", &init_brightness, 200, update_brightness_and_contrast);
//	createTrackbar("contrast", "image", &init_contrast, 200, update_brightness_and_contrast);
//
//	update_brightness_and_contrast(0, 0);
//
//	waitKey();
//
//	return 0;
//}

