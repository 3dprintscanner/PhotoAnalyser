#include "stdafx.h"
#include "ColourTransfer.h"

#include "opencv2/highgui/highgui.hpp"
#include "opencv2/core/core.hpp"
#include "opencv2/imgcodecs/imgcodecs.hpp"
#include "opencv2/imgproc/imgproc.hpp"

#include "iostream"

using namespace cv;
using namespace std;

//ColourTransfer::ColourTransfer()
//{
//}
//
//
//ColourTransfer::~ColourTransfer()
//{
//}


//void histMatch(const Mat &reference, const Mat &target, Mat &result)
//{
//	float const HISTMATCH = 0.00001;
//	double min, max;
//
//	vector<Mat> ref_channels;
//	split(reference, ref_channels);
//
//	vector<Mat> tgt_channels;
//	split(target, tgt_channels);
//
//	int histSize = 256;
//
//	float range[] = { 0, 256 };
//	const float* histRange = { range };
//	bool uniform = true;
//
//	for (int i = 0; i < 3; i++)
//	{
//		Mat ref_hist, tgt_hist;
//		Mat ref_hist_accum, tgt_hist_accum;
//
//		// calc histograms
//		calcHist(&ref_channels[i], 1, 0, Mat(), ref_hist, 1, &histSize, &histRange, uniform, false);
//		calcHist(&tgt_channels[i], 1, 0, Mat(), tgt_hist, 1, &histSize, &histRange, uniform, false);
//
//		// normalize hist data
//
//		minMaxLoc(ref_hist, &min, &max);
//		if (max == 0) continue;
//		ref_hist = ref_hist / max;
//		
//		minMaxLoc(tgt_hist, &min, &max);
//		if (max == 0) continue;
//		tgt_hist = tgt_hist / max;
//
//		// calc accumulated histograms
//
//		ref_hist.copyTo(ref_hist_accum);
//
//		tgt_hist.copyTo(tgt_hist_accum);
//
//		auto src_cdf_data = ref_hist_accum.ptr<float>();
//		auto dst_cdf_data = tgt_hist_accum.ptr<float>();
//
//
//		for (int j = 1; j < 256; j++)
//		{
//			src_cdf_data[j] = src_cdf_data[j] + src_cdf_data[j - 1];
//			dst_cdf_data[j] = dst_cdf_data[j] + dst_cdf_data[j - 1];
//		}
//
//		// normalize accumulated values
//
//		minMaxLoc(ref_hist_accum, &min, &max);
//		ref_hist_accum = ref_hist_accum / max;
//
//		minMaxLoc(tgt_hist_accum, &min, &max);
//		tgt_hist_accum = tgt_hist_accum / max;
//
//
//
//		// Result mask, compare the results between the source and target cdf arrays and set lookups on matches
//
//		Mat Mv(1, 256, CV_8UC1);
//		uchar * M = Mv.ptr<uchar>();
//
//		uchar last = 0;
//
//		for (int j = 0; j < tgt_hist_accum.rows; j++)
//		{
//			float F1 = dst_cdf_data[j];
//			for (uchar k = last; k < ref_hist_accum.rows; k++)
//			{
//				float F2 = src_cdf_data[k];
//				if (abs(F2 - F1) < HISTMATCH || F2 > F1)
//				{
//					M[j] = k;
//					last = k;
//					break;
//
//
//				}
//			}
//		}
//		Mat lut(1, 256, CV_8UC1, M);
//		LUT(tgt_channels[i], lut, tgt_channels[i]);
//
//
//	}
//	merge(tgt_channels, result);
//}
//
//int main(int argc, char* argv[])
//{
//	Mat ref = imread("C:\\Users\\anthony\\Pictures\\Photo0008.jpg");
//	Mat tgt = imread("C:\\Users\\anthony\\Pictures\\Photo0069.jpg");
//
//	if (ref.empty())
//	{
//		cout << "Cannot read Ref image" << endl;
//		return -1;
//	}
//
//	if (tgt.empty())
//	{
//		cout << "Cannot Read TGT image" << endl;
//		return -1;
//	}
//
//
//
//	Mat dst = tgt.clone();
//
//	namedWindow("Reference", WINDOW_AUTOSIZE);
//	namedWindow("Target", WINDOW_AUTOSIZE);
//	namedWindow("Result", WINDOW_AUTOSIZE);
//
//	imshow("Reference", ref);
//	imshow("Target", tgt);
//
//
//	histMatch(ref, tgt, dst);
//	imshow("Result", dst);
//
//	moveWindow("Reference", 0, 0);
//	moveWindow("Target", ref.cols, 0);
//	moveWindow("Result", ref.cols, 0);
//
//	waitKey();
//
//	return 0;
//}