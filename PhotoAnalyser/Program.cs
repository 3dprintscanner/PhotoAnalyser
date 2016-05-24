using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using Newtonsoft.Json;
using OsmSharp.Osm.Streams;

namespace PhotoAnalyser
{
    public class Program
    {


        public static void Main(string[] args)
        {
            var test = new ImageTest();

            var osmTest = new OSMTest();
            osmTest.GetData();




            // load the file into a float array
            var metadata = test.GetMetadata();
            var data = test.LoadFile();
            var evaluator = new MetaDataEvaluator(metadata);
 
            var resolver = new GeometryResolver();

            
            // matrix of pixel values of the heightmap

            var matrix = resolver.GetMatrix(data);

            // calibrate a lookup function to retrieve the elements for a given location

            var matrixCalibrationConstraints = evaluator.GetImageProperties();

            // with the image properties get a matrix position for a given longitude and latitude





        }

    }
}