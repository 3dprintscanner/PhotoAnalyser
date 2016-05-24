namespace PhotoAnalyser
{
    public class ImageProperties
    {
        public ImageProperties()
        {
        }

        public ImageProperties(decimal upperleftlongitude, decimal upperleftlatitude, decimal upperrightlongitude, decimal upperrightlatitude, decimal lowerleftlongitude, decimal lowerleftlatitude, decimal lowerrightlongitude, decimal lowerrightlatitude, int imageWidth, int imageHeight, decimal verticalPitch, decimal horizontalPitch)
        {
            Upperleftlongitude = upperleftlongitude;
            Upperleftlatitude = upperleftlatitude;
            Upperrightlongitude = upperrightlongitude;
            Upperrightlatitude = upperrightlatitude;
            Lowerleftlongitude = lowerleftlongitude;
            Lowerleftlatitude = lowerleftlatitude;
            Lowerrightlongitude = lowerrightlongitude;
            Lowerrightlatitude = lowerrightlatitude;
            ImageWidth = imageWidth;
            ImageHeight = imageHeight;
            VerticalPitch = verticalPitch;
            HorizontalPitch = horizontalPitch;
        }
        
        public decimal Upperleftlongitude { get; set; }
        public decimal Upperleftlatitude { get; set; }
        public decimal Upperrightlongitude { get; set; }
        public decimal Upperrightlatitude { get; set; }
        public decimal Lowerleftlongitude { get; set; }
        public decimal Lowerleftlatitude { get; set; }
        public decimal Lowerrightlongitude { get; set; }
        public decimal Lowerrightlatitude { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }

        public decimal VerticalPitch { get; set; }
        public decimal HorizontalPitch { get; set; }
    }
}



              
              
              
              
              
              
              
              
