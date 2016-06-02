#include "stdafx.h"
#include "GdalTiff.h"
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/core/core.hpp>
#include <opencv2\imgcodecs\imgcodecs.hpp>
#include <opencv2\imgproc\imgproc.hpp>

#include <iostream>

using namespace cv;
using namespace std;


//	Mat im = imread("C:\\Users\\anthony\\Downloads\\bike1.jpg");
//	if (im.empty()){
//		cout << "cannot read image" << endl;
//		return 1;
//	}
//
//	imshow("image", im);
//int main(){
//	waitKey(0);
//	return 0;
//}


/*int main(int argc, char *argv[]){
	int flip_code = 0;
	Mat out_image;

	if (argc != 4){
		cout << "Usage cmd flip_code file_in file_out .. " << endl;
		return -1;
	}

	Mat in_image = imread(argv[2], cv::IMREAD_GRAYSCALE);
	if (in_image.empty()){
		cout << "Error Image could not be read " << argv[2] << endl;
		return -1;
	}

	sscanf_s(argv[1], "%d", &flip_code);
	flip(in_image, out_image, flip_code);
	imshow("Flipped", out_image);
	
	imwrite(argv[3], out_image);
	

	
	cout << "Press Any Key to Exit" << endl;

	waitKey();

	return 0;
}*/


/*int main(int argc, char *argv[]){
	Mat frame;

	VideoCapture vid(argv[1]);

	if (!vid.isOpened()){
		cout << "Video Not Opened" << endl;
		return -1;
	}
	int fps = (int)vid.get(CV_CAP_PROP_FPS);

	namedWindow(argv[1]);

	while (1){
		if (!vid.read(frame)){
			break;
		}
		imshow(argv[1], frame);
		if (waitKey(1000/fps) == 0){
			break;
		}
	}
	return 0;

}*/


//int main(int argc, char *argv[]){
//	Mat frame;
//
//	const char win_name[] = "Live Video";
//	const char file_out[] = "recorded.avi";
//
//	int cam_id = 0;
//
//	double fps = 20;
//
//
//	if (argc == 2){
//		sscanf_s(argv[1], "%d", &cam_id);
//	}
//
//	VideoCapture inVid(cam_id);
//	if (!inVid.isOpened()) return -1;
//
//	int height = (int)inVid.get(CV_CAP_PROP_FRAME_HEIGHT);
//	int width = (int)inVid.get(CV_CAP_PROP_FRAME_WIDTH);
//
//	VideoWriter recVid(file_out, CV_FOURCC('F', 'F', 'D', 'S'), fps, Size(width, height));
//
//	if (!recVid.isOpened()) return -1;
//
//	namedWindow(win_name);
//
//	while (1){
//
//		inVid >> frame;
//		recVid << frame;
//		imshow(win_name, frame);
//		if (waitKey(1000 / fps) >= 0) break;
//
//	}
//
//	inVid.release();
//	return 0;
//}


#define IN_WIN "Orig Image"
#define OUT_WIN "Image Converted .. not saved"

Mat in_img, out_img;


void updateContrast(int TBValContrast, void *userData = 0){
	in_img.convertTo(out_img, -1, TBValContrast / 50.0);
	imshow(OUT_WIN, out_img);
	return;

}


void cbMouse(int event, int x, int y, int flags, void* userdata){
	static int imark = 0;
	char textm[] = "mark999";
	if (event == EVENT_LBUTTONDOWN){
		circle(in_img, Point(x, y), 4, Scalar(0, 0, 255));
		imark++;
		sprintf_s(textm, "mark %d", imark);
		putText(in_img, textm, Point(x + 6, y), FONT_HERSHEY_PLAIN, 1, Scalar(0, 0, 0), 2);
		imshow(IN_WIN, in_img);

	}
}

/// Drag and draw bright squares on the image
void cbDrawMouse(int event, int x, int y, int flags, void* userdata){
	static Point p1, p2;
	static bool p2Set = false;
	if (event == EVENT_LBUTTONDOWN){
		p1 = Point(x, y);
		p2Set = false;
	}
	else if (event == EVENT_MOUSEMOVE && flags == EVENT_FLAG_LBUTTON)
	{
		if (x > in_img.size().width) x = in_img.size().width;
		else if (x < 0) x = 0;
		if (y > in_img.size().height) y = in_img.size().width;
		else if (y < 0) y = 0;
		p2 = Point(x, y);
		p2Set = true;
		in_img.copyTo(out_img);
		rectangle(out_img, p1, p2, Scalar(0, 0, 255));
		imshow(IN_WIN, out_img);

	}else if (event == EVENT_LBUTTONUP && p2Set)
	{
		Mat sub_mat = in_img(Rect(p1, p2));
		sub_mat.convertTo(sub_mat, -1, 2, 0);
		rectangle(in_img, p1, p2, Scalar(0, 0, 255));
		imshow(IN_WIN, in_img);
	}
	return;
}


//int main(int argc, char* argv[]){
//
//	/*const char in_win[] = "Orig Image..";
//	const char out_win[] = "Image Converted .. not saved";*/
//
//	int TBValContrast = 50;
//
//	//Mat out_img;
//
//	if (argc != 2)
//	{
//		cout << "Usage <cmd> <input file>" << endl;
//		return -1;
//	}
//
//	in_img = imread(argv[1]);
//
//	if (in_img.empty()){
//		cout << "Image could not be read " << endl;
//		return - 1;
//	}
//
//	namedWindow(IN_WIN);
//
//	moveWindow(IN_WIN, 0, 0);
//
//	imshow(IN_WIN, in_img);
//
//	namedWindow(OUT_WIN);
//	
//	setMouseCallback(IN_WIN, cbDrawMouse, nullptr);
//
//	createTrackbar("Contrast", OUT_WIN, &TBValContrast, 100,updateContrast);
//
//	cout << "press ESC to Exit" << endl;
//
//	while (true){
//		
//		/*in_img.convertTo(out_img, -1, TBValContrast / 50.0);
//		imshow(OUT_WIN, out_img);*/
//		if (waitKey(50) == 27){
//			break;
//		}
//	}
//	return 0;
//
//}



