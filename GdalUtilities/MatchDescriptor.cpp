#include "stdafx.h"
#include "MatchDescriptor.h"
#include "opencv2/core/core.hpp"
#include "opencv2/highgui/highgui.hpp"
#include <iostream>
#include <opencv2/features2d.hpp>
#include <opencv2/xfeatures2d/nonfree.hpp>

//MatchDescriptor::MatchDescriptor()
//{
//}
//
//
//MatchDescriptor::~MatchDescriptor()
//{
//}
//
//using namespace cv;
//using namespace std;
//using namespace xfeatures2d;
//
//
//int main(int argc, char* argv[])
//{
//	//Mat orig_image = imread(argv[0], IMREAD_GRAYSCALE);
//
//	Mat orig_image = imread("C:\\Users\\anthony\\opencv\\samples\\data\\box_in_scene.png", IMREAD_GRAYSCALE);
//
//	//Mat image_frag = imread(argv[1], IMREAD_GRAYSCALE);
//
//	Mat image_frag= imread("C:\\Users\\anthony\\opencv\\samples\\data\\box.png", IMREAD_GRAYSCALE);
//
//
//	if (orig_image.empty() || image_frag.empty())
//	{
//		cout << "Could Not load image" << endl;
//		return -1;
//	};
//
//
//	vector<KeyPoint> keypoints1, keypoints2;
//
//	//Ptr<FeatureDetector> detector = SURF::create();
//
//	Ptr<FeatureDetector> detector = SIFT::create();
//
//	//Ptr<DescriptorMatcher> matcher = DescriptorMatcher::create("BruteForce-Hamming");
//
//	BFMatcher matcher;
//
//
//
//
//	
//
//	detector->detect(orig_image, keypoints1);
//	detector->detect(image_frag, keypoints2);
//
//	Mat descriptors1, descriptors2;
//
//	detector->compute(orig_image, keypoints1, descriptors1);
//
//	detector->compute(image_frag, keypoints2, descriptors2);
//
//	vector<DMatch> matches12, matches21, goodmatches;
//
//	vector < vector< DMatch >> matches;
//
//	//FlannBasedMatcher matcher;
//
//	/*matcher.match(descriptors1, descriptors2, matches12);
//	matcher.match(descriptors2, descriptors1, matches21);*/
//
//	/*matcher->knnMatch(descriptors1, descriptors2, matches,2);*/
//
//	matcher.knnMatch(descriptors1, descriptors2, matches, 2);
//
//	float ratioT = 0.6;
//
//
//	/*for (size_t i = 0; i < matches12.size(); i++)
//	{
//		DMatch forward = matches12[i];
//		DMatch backward = matches21[forward.trainIdx];
//
//		if (backward.trainIdx == forward.queryIdx)
//		{
//			goodmatches.push_back(forward);
//		}
//
//	}*/
//
//
//	for (int i = 0; i < matches.size(); ++i)
//	{
//		if (matches[i][0].distance < ratioT*(matches[i][1].distance) && (int)matches[i].size() <= 2 && (int)matches[i].size() > 0)
//		{
//			goodmatches.push_back(matches[i][0]);
//		}
//	}
//
//
//	Mat result_matches;
//
//	drawMatches(orig_image, keypoints1, image_frag, keypoints2, goodmatches, result_matches);
//
//	imshow("Matches", result_matches);
//
//	waitKey();
//
//	return 0;
//
//
//
//
//}
