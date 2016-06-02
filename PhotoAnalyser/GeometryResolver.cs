using System;
using System.Linq;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace PhotoAnalyser
{
    
    
    public class GeometryResolver
    {

        public Matrix<float> GetMatrix(float[] pixels, int width, int height)
        {
            var array = GetNestedArray(pixels, width, height);
            return GetMatrix(array);
        }

        public Matrix<float> GetMatrix(InternalTiffData tiffData)
        {
            var array = GetNestedArray(tiffData.Data, tiffData.Width, tiffData.Height);
            return GetMatrix(array);
        }



        private float[,] GetNestedArray(float[] values, int width, int height)
        {
            var floats = new float[width,height];
            for (int i = 0; i < height; i++)
            {
                var row = values.Take(width).ToArray();
                for (int j = 0; j < width; j++)
                {
                    floats[i, j] = row[j];
                }
            }

            return floats;
        }

        private Matrix<float> GetMatrix(float[,] pixels)
        {
            DenseColumnMajorMatrixStorage<float> storage = DenseColumnMajorMatrixStorage<float>.OfArray(pixels);
            var mat = new MathNet.Numerics.LinearAlgebra.Single.DenseMatrix(storage);
            return mat;

        }
        
    }
}