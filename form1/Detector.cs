using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace form1
{
    public static class Detector
    {
        static double CANNY_TRESHOLD = 180.0;
        static double CIRCLE_ACCUMULATOR_TRESHOLD = 120.0;

        public static List<Image<Bgr, Byte>> DrawCircle(Image<Bgr, Byte> image, Label circle_label = null)
        {
            List<Image<Bgr, Byte>> imgs = new List<Image<Bgr, byte>>();
            UMat uimage = removeNoise(image);
            List<CircleF> circles = CvInvoke.HoughCircles(uimage, HoughType.Gradient, 2.0, 20.0, CANNY_TRESHOLD, CIRCLE_ACCUMULATOR_TRESHOLD, 5).ToList();

            imgs.Add(image);
            imgs.Add(image.CopyBlank());

            if (circles.Count > 0)
            {
                CircleF last_circle = circles[circles.Count - 1];
                if (circle_label != null)
                    circle_label.Text = "Circle Coords: " + last_circle.Center;
                foreach (Image<Bgr, Byte> img in imgs)
                    img.Draw(last_circle, new Bgr(Color.Brown), 2);
            }

            return imgs;
        }

        private static UMat removeNoise(Image<Bgr, Byte> frame)
        {
            //define
            UMat uimage = new UMat();
            CvInvoke.CvtColor(frame, uimage, ColorConversion.Bgr2Gray);

            //remove noise
            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(uimage, pyrDown);
            CvInvoke.PyrUp(pyrDown, uimage);

            return uimage;
        }

        
    }
}
