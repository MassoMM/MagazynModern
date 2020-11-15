using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Magazyn
{
   public static class ThemeColor
    {
       public static Color PrimaryColor
        {
            get; set;
        }
        public static Color SecondaryColor
        {
            get; set;
        }
        public static readonly List<string> ColorList = new List<string>() 
       { "	#df2020", "#DC143C","#66B032","#ffcc5c", "#4285F4"};

        public static System.Drawing.Color ChangeColorBrightness(System.Drawing.Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if(correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255-green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;

            }
            return System.Drawing.Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue) ;

        }
     }
}
