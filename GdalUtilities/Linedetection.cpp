#include "stdafx.h"
#include "Linedetection.h"
#include "opencv2/opencv.hpp"
#include "iostream"
Linedetection::Linedetection()
{
}


Linedetection::~Linedetection()
{
}

using namespace std;
using namespace cv;


vector<Vec4i> lines;
vector<float> widths;

Mat input_image, output_image;

inline float line_length(const Point &a, const Point &b)
{
	return sqrt(((b.x - a.x) ^ 2) + ((b.y - a.y) ^ 2));
}

void MyDrawSegments(Mat &image, const vector<Vec4i> &lines, const vector<float> &widths,const Scalar& color, const float length_threshold)
{
	Mat gray;
	if (image.channels() == 1)
	{
		gray = image;
	}
	else if (image.channels() == 3)
	{
		cvtColor(image, gray, COLOR_BGR2GRAY);
	}

	// create mat for lines

	vector<Mat> planes;
	planes.push_back(gray);
	planes.push_back(gray);
	planes.push_back(gray);

	merge(planes, image);

	for (int i = 0; i < lines.size(); ++i)
	{
		const Vec4i v = lines[i];
		Point a(v[0], v[1]);
		Point b(v[2], v[3]);
		if (line_length(a, b) > length_threshold) line(image, a, b, color, widths[i]);
	}
}

void thresholding(int threshold, void*)
{
	input_image.copyTo(output_image);

	MyDrawSegments(output_image, lines, widths, Scalar(0, 255, 0), threshold);

	imshow("Detected_lines", output_image);
}

//int main(int argc, char* argv[])
//{
//	input_image = imread("C:\\Users\\anthony\\opencv\\opencv\\sources\\doc\\tutorials\\photo\\images\\hdr.png", IMREAD_GRAYSCALE);
//
//	Ptr<LineSegmentDetector> ls = createLineSegmentDetector();
//
//	ls->detect(input_image, lines, widths);
//
//	output_image = input_image.clone();
//
//	namedWindow("Detected Lines",WINDOW_AUTOSIZE);
//
//	int threshold_value = 50;
//
//	createTrackbar("Line Length Threshold", "Detected Lines", &threshold_value, 100, thresholding);
//
//	thresholding(threshold_value, nullptr);
//
//	waitKey();
//
//	return 0;
//}
