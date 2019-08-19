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
using Emgu.CV.UI;


namespace form1
{
    public static class Detector
    {
        static double CANNY_TRESHOLD = 180.0;
        static double CIRCLE_ACCUMULATOR_TRESHOLD = 120.0;
        static double CANNY_TRESHOLD_LINKING = 120;

        public static List<Image<Bgr, Byte>> DrawCircle(Image<Bgr, Byte> image, Label circle_label = null)
        {
            List<CircleF> circles;
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

        public static List<Image<Bgr, Byte>> getSquaresAndTriangles(Image<Bgr, Byte> image, bool isTriangle = false, Label shape_label = null)
        {
            List<Triangle2DF> triangleList = new List<Triangle2DF>();
            List<RotatedRect> boxList = new List<RotatedRect>();

            List<Image<Bgr, Byte>> imgs = new List<Image<Bgr, byte>>();
            UMat uimage = removeNoise(image);

            imgs.Add(image);
            imgs.Add(image.CopyBlank());

            UMat cannyEdges = new UMat();
            CvInvoke.Canny(uimage, cannyEdges, CANNY_TRESHOLD, CANNY_TRESHOLD_LINKING);

            LineSegment2D[] lines = CvInvoke.HoughLinesP(
               cannyEdges,
               1, //Distance resolution in pixel-related units
               Math.PI / 45.0, //Angle resolution measured in radians.
               20, //threshold
               30, //min Line width
               10); //gap between lines

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
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
                        if (approxContour.Size == 3) //The contour has 3 vertices, it is a triangle
                        {
                            Point[] pts = approxContour.ToArray();
                            triangleList.Add(new Triangle2DF(
                               pts[0],
                               pts[1],
                               pts[2]
                               ));
                        }
                        else if (approxContour.Size == 4) //The contour has 4 vertices.
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

                            if (isRectangle) boxList.Add(CvInvoke.MinAreaRect(approxContour));
                        }
                    }
                }
            }

            return (isTriangle) ? drawTriangle(imgs, triangleList, shape_label) : drawSquare(imgs, boxList, shape_label);
        }

        private static List<Image<Bgr, Byte>> drawTriangle(List<Image<Bgr, Byte>> imgs, List<Triangle2DF> triangleList, Label triangle_label)
        {
            if (triangleList.Count > 0)
            {
                Triangle2DF last_triangle = triangleList[triangleList.Count - 1];
                if (triangle_label != null)
                    triangle_label.Text = "Triangle Coords: " + last_triangle.Centeroid.ToString();
                foreach (Image<Bgr, Byte> img in imgs)
                    img.Draw(last_triangle, new Bgr(Color.Brown), 2);
            }
            return imgs;
        }

        private static List<Image<Bgr, Byte>> drawSquare(List<Image<Bgr, Byte>> imgs, List<RotatedRect> boxList, Label square_label)
        {
            if (boxList.Count > 0)
            {
                RotatedRect last_box = boxList[boxList.Count - 1];
                if (square_label != null)
                    square_label.Text = "Square Coords: " + last_box.Center.ToString();
                foreach (Image<Bgr, Byte> img in imgs)
                    img.Draw(last_box, new Bgr(Color.Brown), 2);
            }
            return imgs;
        }

        private static UMat removeNoise(Image<Bgr, Byte> frame)
        {
            UMat uimage = new UMat();
            CvInvoke.CvtColor(frame, uimage, ColorConversion.Bgr2Gray);

            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(uimage, pyrDown);
            CvInvoke.PyrUp(pyrDown, uimage);

            return uimage;
        }
    }
}
