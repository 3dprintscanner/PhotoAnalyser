#include "stdafx.h"
#include "Watershed.h"
#include "opencv2/highgui.hpp"
#include "opencv2/core/utility.hpp"
#include "iostream"
#include <opencv2/imgproc/imgproc.hpp>

Watershed::Watershed()
{
}


Watershed::~Watershed()
{
}

using namespace std;
using namespace cv;

void Watershed(const Mat &src)
{
	Mat dst = src.clone();

	Point seed(0, 0);

	int loDiff = 20;
	int upDiff = 20;
	int flags = 4 + CV_FLOODFILL_FIXED_RANGE + CV_FLOODFILL_MASK_ONLY + (255 << 8);

	Mat mask(src.size(), CV_8UC1);

	mask.setTo(0);

	copyMakeBorder(mask, mask, 1, 1, 1, 1, BORDER_REPLICATE);

	Scalar newVal;

	Rect ccomp;

	floodFill(dst, mask, seed, newVal, &ccomp, Scalar(loDiff, loDiff, loDiff), Scalar(upDiff, upDiff, upDiff), flags);

	seed.x = static_cast<float> (src.cols / 2);
	seed.y = static_cast<float>(src.rows / 2);

	Mat mask1 = mask.clone();

	mask1.setTo(0);

	floodFill(dst, mask1, seed, newVal, &ccomp, Scalar(loDiff, loDiff, loDiff), Scalar(upDiff, upDiff, upDiff), flags);


	Mat Mask = mask.clone();

	mask = mask / 2;

	Mask = mask | mask1;

	imshow("Seed Regions", Mask);

	Mat labelImage(src.size(), CV_32SC1);
	labelImage = Mask(Rect(1, 1, src.cols, src.rows));
	labelImage.convertTo(labelImage, CV_32SC1);
	watershed(src, labelImage);
	labelImage.convertTo(labelImage, CV_8U);
	imshow("Watershed", labelImage);

}


int main(int argc, char* argv[])
{
	Mat src = imread("C:\\Users\\anthony\\Downloads\\image1.png", IMREAD_COLOR);

	namedWindow("Source", WINDOW_AUTOSIZE);

	imshow("Source", src);

	Watershed(src);

	cout << "Press Any Key to Exit" << endl;

	waitKey();

	return 0;
}
