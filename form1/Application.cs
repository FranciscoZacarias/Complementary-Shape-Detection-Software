using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;



namespace form1
{
    static class Constants
    {
        public const double divisor_x = 2.38;
        public const double divisor_y = 4.97;
    }

    public partial class Application : Form
    {
        Capture capture;
        Image<Bgr, Byte> originalImage;
        CircleF[] circles;

        Stopwatch watch { get; set; }
        String read_serial;

        String servo_x;
        String servo_y;
        PointF circle_coords;

        bool isDetecting = false;

        public Application()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openPort();
            writeToPortUnparsed(new Point(100,50));

            watch = Stopwatch.StartNew();

            try
            {
                capture = new Emgu.CV.Capture();  //Start Capture object that takes input from default camera

                System.Windows.Forms.Application.Idle += newFrame; 

                lbl_cameraDimensions.Text = "Cam. Dimensions: W:" + capture.Width.ToString() + "H:" + capture.Height.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void newFrame(object sender, EventArgs arg)
        {
            //clean video
            originalImage = capture.QueryFrame().ToImage<Bgr, Byte>().Rotate(270, new Bgr(Color.Black));
            imgbox_video.Image = originalImage.Resize(640, 480, Inter.Nearest);

            //detection video
            circles = Detector.detectCircle(originalImage);
            Image<Bgr, Byte> circleImage = originalImage.CopyBlank();
            foreach (CircleF circle in circles)
            {
                circleImage.Draw(circle, new Bgr(Color.Brown), 2);
                circle_coords = circle.Center;
                lbl_circlepoint.Text = "Circle Coords: " + circle_coords;

                if (watch.ElapsedMilliseconds > 15 && isDetecting)
                {
                    watch = Stopwatch.StartNew();
                    port.Write(String.Format("X{0}Y{1}", (circle_coords.X / Constants.divisor_x), (circle_coords.Y / Constants.divisor_y)));
                }
            }
            imgbox_detection.Image = circleImage;

            //get laser angle from serial data
            read_serial = port.ReadExisting().ToString().Replace(Environment.NewLine, "");
            readAndParseSerialData(read_serial);
            lbl_laserAngle.Text = String.Format("Laser Coords: X:{0} Y:{1}", servo_x, servo_y);
        }

        public void readAndParseSerialData(String serialdata )
        {
            Console.WriteLine("{" + read_serial + "}");
            try
            {
                servo_x = read_serial.Substring(0, read_serial.IndexOf("Y")).Substring(1);
                servo_y = read_serial.Substring(read_serial.IndexOf("Y")).Substring(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void writeToPortUnparsed(Point point)
        {
            port.Write(String.Format("X{0}Y{1}", point.X, point.Y));
        }

        public void openPort()
        {
            if(!port.IsOpen)
            {
                port.Open();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(null);
        }

        private void btn_sendCoords_Click(object sender, EventArgs e)
        {
            port.Write("X" + textbox_x.Text + "Y" + textbox_y.Text);
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            writeToPortUnparsed(new Point(rnd.Next(40, 121), rnd.Next(40, 121)));
        }

        private void btn_debug_Click(object sender, EventArgs e)
        {
            DebugForm df = new DebugForm(port);
            df.Show();
        }

        private void btn_toggleDetect_Click(object sender, EventArgs e)
        {
            isDetecting = !isDetecting;
            if (isDetecting)
            {
                btn_toggleDetect.BackColor = Color.PaleGreen;
            }
            else
            {
                btn_toggleDetect.BackColor = Color.Tomato;
            }
        }
    }
}
