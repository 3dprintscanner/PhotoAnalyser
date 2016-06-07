#include "stdafx.h"
#include "ConnectedComponents.h"
#include "opencv2/imgproc.hpp"
#include "opencv2/highgui.hpp"
#include "opencv2/core/utility.hpp"
#include "iostream"

ConnectedComponents::ConnectedComponents()
{
}


ConnectedComponents::~ConnectedComponents()
{
}


using namespace std;
using namespace cv;

Mat img;
int threshval = 227;

void on_trackbar(int, void*)
{
	Mat bw = threshval < 128 ? (img < threshval) : (img > threshval);

	Mat labelImage(img.size(), CV_32S);

	Mat stats, centroids;

	int nLabels = connectedComponentsWithStats(bw, labelImage, stats, centroids);


	// Show connected components with rand colour

	vector<Vec3b> colours(nLabels);

	colours[0] = Vec3b(0, 0, 0);

	for (int i = 1; i < colours.size(); ++i)
	{
		colours[i] = Vec3b((rand() & 200), (rand() & 200), (rand() & 200));
	}
	Mat dst(img.size(), CV_8UC3);

	for (int i = 0; i < dst.rows; ++i)
	{
		for (int j = 0; j < dst.cols; ++j)
		{
			int label = labelImage.at<int>(i, j);
			Vec3b &pixel = dst.at<Vec3b>(i, j);

			pixel = colours[label];
		}
	}

	for (int i = 1; i < nLabels; ++i)
	{
		float a = stats.at<int>(i, CC_STAT_AREA);
		Point org(centroids.at<double>(i, 0));
		String txtarea;
		std::ostringstream buff;
		buff << a;
		txtarea = buff.str();
		putText(dst, txtarea, org, FONT_HERSHEY_COMPLEX_SMALL, 1, Scalar(255, 255, 255), 1);
	}

	imshow("Connected Components", dst);
}

/*int main(int argc, char* argv[])
{
	img = imread("C:\\Users\\anthony\\opencv\\opencv\\sources\\doc\\tutorials\\imgproc\\threshold\\images\\Threshold_Tutorial_Original_Image.jpg", 0);
	namedWindow("Connected Components");
	createTrackbar("Threshold", "Connected Components", &threshval, 255, on_trackbar);

	waitKey(0);
	return 0;

}*/



