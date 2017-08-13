#include "stdafx.h"
#include "TifReader.h"
#include "gdal_priv.h"


GDALDataset *po_dataset;
GDALRasterBand *raster_band;


TifReader::TifReader()
{
	GDALAllRegister();
}


TifReader::~TifReader()
{
}


bool TifReader::LoadFile(char* path)
{
	po_dataset = (GDALDataset *)GDALOpen(path, GA_ReadOnly);
	if (po_dataset != nullptr) return true;
	return false;

}

void TifReader::GetRasterBand(int bandId)
{
	raster_band = po_dataset->GetRasterBand(bandId);
}

float TifReader::GetPixelValue(const int& x, const int& y)
{
	float f = 0.0;
	
	return f;
	//raster_band->RasterIO(GF_Read,)
}


