using System;

namespace PhotoAnalyser
{
    public class MetaDataEvaluator
    {
        private readonly MD_Metadata _metadata;

        public MetaDataEvaluator(MD_Metadata metadata)
        {
            _metadata = metadata;
        }

        public Tuple<decimal, decimal> GetPitch(int x, int y)
        {
            var scaling = _metadata.spatialRepresentationInfo.MD_GridSpatialRepresentation.axisDimensionProperties;

            decimal rowPitch = -1; // arcseconds
            decimal columnPitch = -1 ; // arcseconds

            foreach (var property in scaling)
            {
                switch (property.MD_Dimension.dimensionName.MD_DimensionNameTypeCode.Value)
                {
                    case "column":
                        columnPitch = property.MD_Dimension.resolution.Scale.Value;
                        break;
                    case "row":
                        rowPitch = property.MD_Dimension.resolution.Scale.Value;
                        break;
                    default:
                        break;
                }
            }

            return new Tuple<decimal, decimal>(rowPitch,columnPitch);
        }

        public ImageProperties GetImageProperties()
        {
            var props = new ImageProperties();
            props.ImageHeight =
                _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.imageDetails.imageRaster.numberOfRows;
            props.ImageWidth = _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.imageDetails.imageRaster.numberOfColumns;
            props.HorizontalPitch = _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.imageDetails.imageRaster.columnSpacing.Value;
            props.VerticalPitch = _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.imageDetails.imageRaster.rowSpacing.Value;
            props.Upperleftlongitude =
                _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.productExtent.frameCoordsGeographic
                    .upperLeftLongitude.Value;
            props.Upperleftlatitude = _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.productExtent.frameCoordsGeographic
                    .upperLeftLatitude.Value;
            props.Upperrightlongitude =_metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.productExtent.frameCoordsGeographic
                    .upperRightLongitude.Value;
            props.Upperrightlatitude = _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.productExtent.frameCoordsGeographic
                    .upperRightLatitude.Value;
            props.Lowerleftlongitude = _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.productExtent.frameCoordsGeographic
                    .lowerLeftLongitude.Value;
            props.Lowerleftlatitude = _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.productExtent.frameCoordsGeographic
                    .lowerLeftLatitude.Value;
            props.Lowerrightlongitude = _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.productExtent.frameCoordsGeographic
                    .lowerRightLongitude.Value;
            props.Lowerrightlatitude = _metadata.contentInfo[0].TSXX_addMD.DEMInfo.productDetails.productExtent.frameCoordsGeographic
                    .lowerRightLatitude.Value;

            return props;

        }
    }
    
}