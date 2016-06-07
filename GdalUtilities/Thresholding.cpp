#include "stdafx.h"
#include "Thresholding.h"
#include "opencv2/opencv.hpp"

#define THRESHOLDING "Thresholding"
#define ADAPT_THRESHOLD "Adaptive Thresholding"
#define SRC "Source"
#define THRESH_TRACKBAR "threshold"
#define BLOCK_SIZE_TRACKBAR "block size"
#define PARAM_C "C"

Thresholding::Thresholding()
{
}


Thresholding::~Thresholding()
{
}



using namespace std;
using namespace cv;

Mat src, dst, adaptDst;
int threshold_value, block_size, C;

//void thresholding(int, void*)
//{
//	threshold(src, dst, threshold_value, 255, THRESH_BINARY);
//
//	imshow(THRESHOLDING, dst);
//	
//}

void adaptThreshAndShow()
{
	adaptiveThreshold(src, adaptDst, 255, CV_ADAPTIVE_THRESH_MEAN_C, THRESH_BINARY, block_size, C);

	imshow(ADAPT_THRESHOLD, adaptDst);
}

void adaptiveThresholding1(int, void*)
{
	static int prev_block_size = block_size;
	if ((block_size% 2) == 0)
	{
		if (block_size > prev_block_size)
		{
			block_size++;
		} else if (block_size < prev_block_size)
		{
			block_size--;
		}
	}
	if (block_size <= 1) block_size = 3;

	adaptThreshAndShow();
}


void adaptiveThresholding2(int, void*)
{
	adaptThreshAndShow();
}

//int main(int argc, char* argv[])
//{
//	src = imread("C:\\Users\\anthony\\opencv\\opencv\\sources\\doc\\tutorials\\imgproc\\threshold\\images\\Threshold_Tutorial_Original_Image.jpg", CV_LOAD_IMAGE_GRAYSCALE);
//
//	if (src.empty())
//	{
//		cout << "image could not be loaded" << endl;
//		return -1;
//	}
//
//	dst = src.clone();
//	adaptDst = src.clone();
//
//	// create windows
//
//	namedWindow(SRC);
//	namedWindow(THRESHOLDING);
//	namedWindow(ADAPT_THRESHOLD);
//
//	imshow(SRC, src);
//
//	// allah trackbar
//
//	threshold_value = 127;
//	block_size = 7;
//	C = 10;
//
//	createTrackbar(THRESH_TRACKBAR, THRESHOLDING, &threshold_value, 255, thresholding);
//	createTrackbar(BLOCK_SIZE_TRACKBAR, ADAPT_THRESHOLD, &block_size, 25, adaptiveThresholding1);
//	createTrackbar(PARAM_C, ADAPT_THRESHOLD, &C, 255, adaptiveThresholding2);
//
//
//	// perform first thresholding op
//
//	thresholding(threshold_value, nullptr);
//	adaptiveThresholding1(block_size, nullptr);
//	adaptiveThresholding2(C, nullptr);
//
//	cout << "Press Any Key to Exit" << endl;
//
//	waitKey();
//	return 0;
//}
