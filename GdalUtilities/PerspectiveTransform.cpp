#include "stdafx.h"
#include "PerspectiveTransform.h"

#include "opencv2/highgui/highgui.hpp"
#include "opencv2/core/core.hpp"
#include "opencv2/imgcodecs/imgcodecs.hpp"
#include "opencv2/imgproc/imgproc.hpp"

#include "iostream"

using namespace cv;
using namespace std;


PerspectiveTransform::PerspectiveTransform()
{
}


PerspectiveTransform::~PerspectiveTransform()
{
}


Point2f center_point(0, 0);

Point2f ComputeIntersect(Vec4i a, Vec4i b)
{
	int x1 = a[0], y1 = a[1], x2 = a[2], y2 = a[3], x3 = b[0], y3 = b[1], x4 = b[2], y4 = b[3];

	// see https://en.wikipedia.org/wiki/Line%E2%80%93line_intersection for line intersection by determinants, det = 0 means lines are parallel
	
	if (float d = ((float)((x1 - x2)*(y3 - y4)) - ((y1 - y2)*(x3 - x4))))
	{
		Point2f pnt;
		
		// solve intersects by cremers rule
		pnt.x = ((x1*y2 - y1*x2)* (x3 - x4) - (x1 - x2)*(x3*y4 - y3*x4)) / d;
		pnt.y = ((x1*y2 - y1*x2)* (y3 - y4) - (y1 - y2)*(x3*y4 - y3*x4)) / d;
		return pnt;
	}
	else
	{
		return Point2f(-1, -1);
	}
}

void SortCorners(vector<Point2f>& corner_points, Point2f center_point){

	vector<Point2f> top, bot;

	for (int i = 0; i < corner_points.size(); ++i)
	{
		if (corner_points[i].y < center_point.y)
		{
			top.push_back(corner_points[i]);
		}
		else
		{
			bot.push_back(corner_points[i]);
		}
	}

	Point2f tl = top[0].x > top[1].x ? top[1] : top[0];
	Point2f tr = top[0].x > top[1].x ? top[0] : top[1];
	Point2f bl = bot[0].x > bot[1].x ? bot[1] : bot[0];
	Point2f br = bot[0].x > bot[1].x ? bot[0] : bot[1];

	corner_points.clear();
	corner_points.push_back(tl);
	corner_points.push_back(tr);
	corner_points.push_back(br);
	corner_points.push_back(bl);
}


int main(int argc, char* argv[])
{
	Mat src = imread("C:\\Users\\anthony\\Documents\\Visual Studio 2013\\Projects\\PhotoAnalyser\\Debug\\img.jpg");

	if (src.empty())
	{
		cout << "Could Not read image \n";

		return -1;
	}

	Mat dst = src.clone();

	Mat bw;

	cvtColor(src, bw, CV_BGR2GRAY);

	Canny(bw, bw, 100, 100, 3);
	vector<Vec4i> lines;
	HoughLinesP(bw, lines, 1, CV_PI / 180, 70, 30, 10);

	vector<Point2f> corner_points;

	for (int i = 0; i < lines.size(); ++i)
	{
		for (int j = i+1; j < lines.size(); ++j)
		{
			Point2f pnt = ComputeIntersect(lines[i], lines[j]);
			if (pnt.x >= 0 && pnt.y >= 0) corner_points.push_back(pnt);
		}
	}

	// check points for quad
	vector<Point2f> approx;
	approxPolyDP(Mat(corner_points), approx, arcLength(Mat(corner_points), true)* 0.02, true);

	if (approx.size() != 4)
	{
		cout << "Object is not a quadrilateral" << endl;
		return -1;
	}

	// get center point, average the points


	for (int i = 0; i < corner_points.size(); ++i)
	{
		center_point += corner_points[i];
		
	}
	center_point *= (1. / corner_points.size());


	for (int i = 0; i < corner_points.size(); ++i)
	{
		Vec4i v = lines[i];
		line(dst, Point(v[0], v[1]), Point(v[2], v[3]), CV_RGB(0, 0, 255));

	}

	// draw corners

	circle(dst, corner_points[0], 3, CV_RGB(255, 0, 0), 2);
	circle(dst, corner_points[1], 3, CV_RGB(0, 255, 0), 2);
	circle(dst, corner_points[2], 3, CV_RGB(0, 0, 255), 2);
	circle(dst, corner_points[3], 3, CV_RGB(255, 255, 255), 2);

	circle(dst, center_point, 3, CV_RGB(255, 255, 0), 2);

	Mat quad = Mat::zeros(src.rows, src.cols / 2, CV_8UC3);

	vector<Point2f> quad_points;

	quad_points.push_back(Point2f(0, 0));
	quad_points.push_back(Point2f(quad.cols, 0));
	quad_points.push_back(Point2f(quad.cols, quad.rows));
	quad_points.push_back(Point2f(0, quad.rows));

	// draw corners

	circle(dst, quad_points[0], 3, CV_RGB(255, 0, 0), 2);
	circle(dst, quad_points[1], 3, CV_RGB(0, 255, 0), 2);
	circle(dst, quad_points[2], 3, CV_RGB(0, 0, 255), 2);
	circle(dst, quad_points[3], 3, CV_RGB(255, 255, 255), 2);

	Mat transMatrix = getPerspectiveTransform(corner_points, quad_points);
	warpPerspective(src, quad, transMatrix, quad.size());

	namedWindow("original");
	namedWindow("selected");
	namedWindow("corrected");

	imshow("original", src);
	imshow("selected", dst);
	imshow("corrected", quad);

	waitKey();
	return 0;
}
