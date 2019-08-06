using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace form1
{
    public static class Detector
    { 
        public static CircleF[] detectCircle(Image<Bgr, Byte> frame)
        {
            //define
            UMat uimage = new UMat();
            CvInvoke.CvtColor(frame, uimage, ColorConversion.Bgr2Gray);

            //remove noise
            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(uimage, pyrDown);
            CvInvoke.PyrUp(pyrDown, uimage);
     
            Stopwatch watch = Stopwatch.StartNew();
            double cannyThreshold = 180.0;
            double circleAccumulatorThreshold = 120;
            CircleF[] circles = CvInvoke.HoughCircles(uimage, HoughType.Gradient, 2.0, 20.0, cannyThreshold, circleAccumulatorThreshold, 5);
            
            return circles;
        }
    }
}
