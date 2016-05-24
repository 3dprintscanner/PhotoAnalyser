using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex32;

namespace PhotoAnalyser
{
    public class HeightmapGeometryResolver : IGeometryResolver
    {
        private readonly Matrix<float> _heightMatrix;
        private readonly ImageProperties _properties;

        public HeightmapGeometryResolver(Matrix<float> heightMatrix, ImageProperties properties)
        {
            _heightMatrix = heightMatrix;
            _properties = properties;
        }

        public Tuple<int, int> GetPixelIndex(decimal lat, decimal lng)
        {
            // is the latlong within the image bounds??
            if (lat <= _properties.Lowerleftlatitude || lat >= _properties.Upperleftlatitude ||
                lng <= _properties.Lowerleftlongitude || lng >= _properties.Lowerrightlongitude)
            {
                throw new OutOfBoundsException($"{lat} - {lng}");
            }

            var latFromBottom = lat - _properties.Lowerleftlatitude;
            var longfromLeft = lng - _properties.Lowerleftlongitude;

            int pixelsFromBottom = (int) Math.Round(latFromBottom/_properties.VerticalPitch);
            int pixelsFromside = (int) Math.Round(longfromLeft/_properties.HorizontalPitch);

            return new Tuple<int, int>(pixelsFromside,pixelsFromBottom);
        }

        public Matrix GetIntermediaryPixelSet(Tuple<decimal, decimal> bottomLeft, Tuple<decimal, decimal> topRight)
        {
            // get the start index of the pixels and get the number of rows/cols needed
        }

        
    }
}