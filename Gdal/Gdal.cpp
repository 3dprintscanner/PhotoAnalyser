// Gdal.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "gdal.h"
#include "gdal_priv.h"
#include "cpl_conv.h"
#include <iostream>

using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	GDALDataset *po_dataset;
	GDALRasterBand *raster_band;
	int blockXSize, blockYSize, gotMin, gotMax, nXSize;
	double adfMinMax[2];
	float *pafScanline;

	GDALAllRegister();

	po_dataset = (GDALDataset *)GDALOpen("C:\\Users\\anthony\\Downloads\\WorldDEM_DTM_Oxford_UK\\WorldDEM_DTM_04_N51_86_W001_42\\DEM\\WorldDEM_DTM_04_N51_86_W001_42_DEM.tif", GA_ReadOnly);

	if (po_dataset == NULL)
	{
		printf("Cannot Load File");
	}
	double adfGeoTransform[6];

	if (po_dataset->GetProjectionRef() != NULL)
	{
		printf("Projection is '%s' \n", po_dataset->GetProjectionRef());
	}
	if (po_dataset->GetGeoTransform(adfGeoTransform) == CE_None)
	{
		printf("Origin is '%d'", adfGeoTransform[0]);
	}

	raster_band = po_dataset->GetRasterBand(1);

	raster_band->GetBlockSize(&blockXSize, &blockYSize);

	printf("Block = '%d'x'%d' Type='%s', ColorInterp='%s'\n", blockXSize, blockYSize, GDALGetDataTypeName(raster_band->GetRasterDataType()), GDALGetColorInterpretationName(raster_band->GetColorInterpretation()));
	
	adfMinMax[0] = raster_band->GetMinimum(&gotMin);
	adfMinMax[1] = raster_band->GetMaximum(&gotMax);

	if (!(gotMin && gotMax))
	{
		GDALComputeRasterMinMax((GDALRasterBandH)raster_band, TRUE, adfMinMax);
	}

	printf(" Min is '%.3f', Max is '%.3f' \n", adfMinMax[0], adfMinMax[1]);

	if (raster_band->GetColorTable() != NULL)
	{
		printf("Colour Table has '%d' entries", raster_band->GetColorTable()->GetColorEntryCount());
	}

	nXSize = raster_band->GetXSize();

	pafScanline = static_cast<float*>(CPLMalloc(sizeof(float)* nXSize));


	raster_band->RasterIO(GF_Read, 0, 0, nXSize, 1, pafScanline, nXSize, 1, GDT_Float32, 0, 0);
	
	
	std::cout << "Sucess Loading TIF file!!! " << std::endl;

	
}

