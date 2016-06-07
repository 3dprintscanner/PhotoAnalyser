#include "stdafx.h"
#include "FloodFill.h"
#include "opencv2/opencv.hpp"
#include "iostream"


FloodFill::FloodFill()
{
}


FloodFill::~FloodFill()
{
}


using namespace std;
using namespace cv;


Mat image, image1, image_orig;
int lodiff = 20, upDiff = 30;
int loCanny = 10, upCanny = 150;


void onMouse(int evnt, int x, int y, int, void*)
{
	if (evnt != CV_EVENT_LBUTTONDOWN) return;


	Point seed = Point(x, y);

	int flags = 4 + CV_FLOODFILL_FIXED_RANGE;

	int b = static_cast<unsigned>(theRNG()) & 255;
	int g = static_cast<unsigned>(theRNG()) & 255;
	int r = static_cast<unsigned>(theRNG()) & 255;

	Rect ccomp;

	Scalar newval = Scalar(b, g, r);

	Mat dst = image;

	floodFill(dst, seed, newval, &ccomp, Scalar(lodiff, lodiff, lodiff), Scalar(upDiff, upDiff, upDiff), flags);

	imshow("image", dst);

	// canny mask

	Mat mask;

	Canny(image_orig, mask, loCanny, upCanny);

	imshow("Canny edges", mask);

	copyMakeBorder(mask, mask, 1, 1, 1, 1, BORDER_REPLICATE);

	Mat dstl = image1;

	floodFill(dstl, mask, seed, newval, &ccomp, Scalar(lodiff, lodiff, lodiff), Scalar(upDiff, upDiff, upDiff));

	imshow("FF with Cannny", dstl);
		
}

int main(int argc, char* argv[])
{
	image = imread("C:\\Users\\anthony\\opencv\\opencv\\sources\\doc\\tutorials\\imgproc\\threshold\\images\\Threshold_Tutorial_Original_Image.jpg", CV_LOAD_IMAGE_COLOR);
	image_orig = image.clone();

	image1 = image.clone();

	namedWindow("image");

	imshow("image", image);

	createTrackbar("lo_diff", "image", &lodiff, 255, 0);
	createTrackbar("up_diff", "image", &upDiff, 255, 0);
	createTrackbar("lo_canny", "image", &loCanny, 255, 0);
	createTrackbar("up_canny", "image", &upCanny, 255, 0);

	setMouseCallback("image", onMouse, nullptr);

	cout << "Press Any key to Exit" << endl;

	waitKey();

	return 0;
}

