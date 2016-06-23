#include "stdafx.h"
#include "FastDetector.h"


FastDetector::FastDetector()
{
}


FastDetector::~FastDetector()
{
}


//#include "iostream"
//#include "math.h"
//using namespace std;
//
//
//int main(int argc, char* argv[]){
//
//		
//	int x = 0;
//	cout << x << endl;
//	int y = ++x;
//	cout << x << endl;
//	cout << y << endl;
//	int z = x++;
//	cout << x << endl;
//	cout << y << endl;
//	cout << z << endl;
//	
//	int i; 
//	char buffer[256];
//	
//	cout << "Enter a Number" << endl;
//
//	fgets(buffer, 256, stdin);
//	
//	i = atoi(buffer);
//
//	cout << "The Value of the number is " << i << " Its value squared is " << pow(i,2) << endl;
//	
//	
//	
//	for (int i = 1; i <= 100; ++i){
//
//		if (i % 3 == 0 && i % 5 == 0){
//			cout << "FizzBuzz" << endl;
//			continue;
//		}
//		if (i % 3 == 0){
//			cout << "Fizz" << endl;
//			continue;
//		}
//		if (i % 5 == 0){
//			cout << "Buzz" << endl;
//			continue;
//		}
//		cout << i << endl;
//	};
//	getchar();
//};

//
//#include  "opencv2/core.hpp"
//#include  "opencv2/highgui.hpp"
//#include  "opencv2/imgproc.hpp"
//#include  "opencv2/features2d.hpp"
//#include "opencv2/xfeatures2d/nonfree.hpp"
//#include "iostream"
//
//using namespace cv;
//using namespace std;
//using namespace xfeatures2d;
//
//
//int main(int argc, char* argv[])
//{
//	Mat in_img = imread("C:\\Users\\anthony\\opencv\\samples\\data\\lena.jpg", CV_LOAD_IMAGE_COLOR);
//
//	if (in_img.empty())
//	{
//		cout << "Image Not Loaded" << endl;
//		return -1;
//	}
//
//	cvtColor(in_img, in_img, COLOR_BGR2GRAY);
//
//	Mat in_img2,in_img3,in_img4,in_img5;
//
//
//	in_img.copyTo(in_img2);
//
//	in_img.copyTo(in_img3);
//
//	in_img.copyTo(in_img4);
//
//	in_img.copyTo(in_img5);
//
//	vector<KeyPoint> keypoints1, keypoints2,keypoints3,keypoints4,keypoints5;
//
//	/*FAST(in_img, keypoints1, 80);
//	FAST(in_img, keypoints2, 100);*/
//
//	Ptr<AKAZE> akazeptr = AKAZE::create();
//
//	Ptr<SURF> surf = SURF::create();
//
//	surf->detect(in_img5, keypoints5);
//
//
//	akazeptr->detect(in_img2, keypoints3);
//	
//	Mat out_img1, out_img2, out_img3, out_img4,out_img5;
//	
//	// dispose akaze
//
//	
//	Ptr<KAZE> kaze = KAZE::create();
//
//
//	kaze->detect(in_img3, keypoints4);
//
//	Ptr<ORB> orb = ORB::create();
//
//
//
//	orb->detect(in_img4, keypoints2);
//		
//
//	drawKeypoints(in_img, keypoints1, out_img1, Scalar::all(-1), 0);
//
//	drawKeypoints(in_img, keypoints2, out_img2, Scalar::all(-1), 0);
//
//	drawKeypoints(in_img, keypoints3, out_img3, Scalar::all(-1), 0);
//
//	drawKeypoints(in_img, keypoints4, out_img4, Scalar::all(-1), 0);
//
//	drawKeypoints(in_img, keypoints5, out_img5, Scalar::all(-1), 0);
//
//	imshow("out_img1", out_img1);
//	imshow("ORB keypoints", out_img2);
//	imshow("AKAZE Keypoints", out_img3);
//	imshow("KAZE Keypoints", out_img4);
//	imshow("SURF Keypoints", out_img5);
//
//	waitKey();
//
//	return 0;
//
//
//}




