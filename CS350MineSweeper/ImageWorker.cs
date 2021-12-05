using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CS350MineSweeper
{
    class ImageWorker
    {
        public static Image RescaleImage(Image origImage, Size size)
        {
            //Variables
            int origWidth = origImage.Width;
            int origHeight = origImage.Height;

            //Percent variables
            float percent = 0;
            float percentW = 0;
            float percentH = 0;

            //Calculate percentages
            percentW = ((float)size.Width / (float)origWidth);
            percentH = ((float)size.Height / (float)origHeight);

            //Change percent values
            if (percentW < percentH)
            {
                percent = percentW;
            }
            else
            {
                percent = percentH;
            }

            //New width and height
            int newWidth = (int)(origWidth * percent);
            int newHeight = (int)(origHeight * percent);

            //New image and graphics objects
            Bitmap b = new Bitmap(newWidth, newHeight);
            Graphics g = System.Drawing.Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            //Draw new image
            g.DrawImage(origImage, 0, 0, newWidth, newHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }
    }
}
