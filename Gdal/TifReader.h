#pragma once
class TifReader
{
public:
	TifReader();
	~TifReader();
	bool LoadFile(char* path);
	void GetRasterBand(int bandId);
	float GetPixelValue(const int &x, const int &y);

};

