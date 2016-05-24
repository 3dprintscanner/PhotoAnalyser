using System;
using System.IO;
using System.Security.Policy;
using System.Xml;
using System.Xml.Serialization;
using BitMiracle.LibTiff.Classic;

namespace PhotoAnalyser
{
    public class InternalTiffData
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public float[] Data { get; set; }
    }
    
    public class ImageTest
    {


        public InternalTiffData LoadFile()
        {



            using (var inputImage = Tiff.Open(@"c:\test\test.tif", "r"))
            {
                var width = inputImage.GetField(TiffTag.IMAGEWIDTH)[0].ToInt();
                var height = inputImage.GetField(TiffTag.IMAGELENGTH)[0].ToInt();
                var inputImageData = new byte[width*height*sizeof (int)];
                var offset = 0;
                for (var i = 0; i < inputImage.NumberOfStrips(); i++)
                {
                    offset += inputImage.ReadRawStrip(i, inputImageData, offset, (int) inputImage.RawStripSize(i));
                }

                var outputArray = new float[inputImageData.Length/4];

                for (var i = 0; i < outputArray.Length; i++)
                {
                    outputArray[i] = BitConverter.ToSingle(inputImageData, i*4);
                    if (i%100 == 0)
                    {
                        Console.WriteLine(outputArray[i]);
                    }
                }

                return new InternalTiffData() {Data = outputArray, Height = height, Width = width};
                // convert the array into a int buffer




            }


        }

        public MD_Metadata GetMetadata()
        {
            var fileStream = new FileStream(@"C:\test\test.xml", FileMode.Open);

            var reader = XmlReader.Create(fileStream);

            XmlSerializer serializer = new XmlSerializer(typeof (MD_Metadata));

            return (MD_Metadata) serializer.Deserialize(reader);


        }


    }
}