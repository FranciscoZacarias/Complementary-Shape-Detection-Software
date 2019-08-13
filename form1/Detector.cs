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
using Emgu.CV.Util;

namespace form1
{
    public static class Detector
    {
        static List<CircleF> circles;
        static List<Triangle2DF> triangleList;
        static List<RotatedRect> boxList;

        static double CANNY_TRESHOLD = 180.0;
        static double CIRCLE_ACCUMULATOR_TRESHOLD = 120.0;

        public static List<Image<Bgr, Byte>> DrawCircle(Image<Bgr, Byte> image, Label circle_label = null)
        {
            List<Image<Bgr, Byte>> imgs = new List<Image<Bgr, byte>>();
            UMat uimage = removeNoise(image);
            circles = CvInvoke.HoughCircles(uimage, HoughType.Gradient, 2.0, 20.0, CANNY_TRESHOLD, CIRCLE_ACCUMULATOR_TRESHOLD, 5).ToList();

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

        public static List<Image<Bgr, Byte>> getSquaresAndTriangles(Image<Bgr, Byte> image, bool isSquare = true)
        {
            List<Image<Bgr, Byte>> imgs = new List<Image<Bgr, byte>>();
            imgs.Add(image);
            imgs.Add(image.CopyBlank());

            triangleList = new List<Triangle2DF>();
            boxList = new List<RotatedRect>(); 

            UMat cannyEdges = new UMat();

            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(cannyEdges, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                int count = contours.Size;

                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint())
                    {
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                        if (CvInvoke.ContourArea(approxContour, false) > 250) //only consider contours with area greater than 250
                        {
                            if (!isSquare)
                            {
                                return drawTriangle(approxContour, image, imgs);
                            }
                            else
                            {
                                findSquare(approxContour);
                                return drawSquare(image, imgs);
                            }
                        }
                    }
                }
            }
            return imgs;
        }

        private static List<Image<Bgr, Byte>> drawSquare(Image<Bgr, Byte> originalImg, List<Image<Bgr, Byte>> imgs)
        {
            if (boxList.Count > 0)
            {
                RotatedRect last_square = boxList[boxList.Count - 1];
                foreach (Image<Bgr, Byte> img in imgs)
                    img.Draw(last_square, new Bgr(Color.Brown), 2);
            }
            return imgs;
        }

        private static void findSquare(VectorOfPoint approxContour)
        {
            bool isRectangle = true;
            Point[] pts = approxContour.ToArray();
            LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

            for (int j = 0; j < edges.Length; j++)
            {
                double angle = Math.Abs(
                   edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                if (angle < 80 || angle > 100)
                {
                    isRectangle = false;
                    break;
                }
            }

            if (isRectangle)
                boxList.Add(CvInvoke.MinAreaRect(approxContour));
        }

        private static List<Image<Bgr, Byte>> drawTriangle(VectorOfPoint approxContour, Image<Bgr, Byte> originalImg, List<Image<Bgr, Byte>> imgs)
        {
            Point[] pts = approxContour.ToArray();
            triangleList.Add(new Triangle2DF(
               pts[0],
               pts[1],
               pts[2]
               ));

            if (triangleList.Count > 0)
            {
                Triangle2DF last_triangle = triangleList[triangleList.Count - 1];
                foreach (Image<Bgr, Byte> img in imgs)
                    img.Draw(last_triangle, new Bgr(Color.Brown), 2);
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
