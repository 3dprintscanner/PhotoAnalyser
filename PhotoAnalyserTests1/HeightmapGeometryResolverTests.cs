using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex32;
using MathNet.Numerics.LinearAlgebra.Storage;
using PhotoAnalyser;
using NUnit.Framework;
namespace PhotoAnalyser.Tests
{
    [TestFixture()]
    public class HeightmapGeometryResolverTests
    {
        [Test()]
        public void GetPixelIndexTest()
        {
            var pixels = new float[,]{{12,13,14,15,16,17},{13,14,15,16,17,18}};
            var storage = DenseColumnMajorMatrixStorage<float>.OfArray(pixels);
            var heightMatrix = new MathNet.Numerics.LinearAlgebra.Single.DenseMatrix(storage);

            var imageProperties = new ImageProperties()
            {
                Lowerleftlatitude = 0,
                Lowerrightlatitude = 0,
                Upperleftlatitude = 1,
                Upperrightlatitude = 1,
                Lowerleftlongitude = 0,
                Lowerrightlongitude = 1,
                Upperleftlongitude = 1,
                Upperrightlongitude = 1,
                HorizontalPitch = 0.05M,
                VerticalPitch = 0.06M,
                ImageHeight = 100,
                ImageWidth = 150
            };
            
            var resolver = new HeightmapGeometryResolver(heightMatrix,imageProperties);

            var index = resolver.GetPixelIndex(0.5M, 0.5M);

            Console.WriteLine("Testing");
        }
    }
}
