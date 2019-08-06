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
    public partial class Application : Form
    {
        Capture capture;
        Image<Bgr, Byte> originalImage;
        CircleF[] circles;

        Stopwatch watch { get; set; }

        String servo_x;
        String servo_y;

        //for manual move
        Point pt;
        int debug;

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

                lbl_cameraDimensions.Text += " Width:" + capture.Width.ToString() + " Height:" + capture.Height.ToString();
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
                lbl_circlepoint.Text = "Circle Coords: " + circle.Center;
            }
            imgbox_detection.Image = circleImage;

            //get laser angle from serial data
            String read_serial = port.ReadExisting().ToString();

            
            if (read_serial.Length > 0)
            {
                Console.WriteLine("{0} Serial Data: " + read_serial, ++debug);
                /*
                servo_x = read_serial.Substring(0, read_serial.IndexOf("Y")).Substring(1);
                servo_y = read_serial.Substring(read_serial.IndexOf("Y")).Substring(1);  //Length cannot be less than zero.
                lbl_laserAngle.Text = String.Format("Laser Coords: X:{0} Y:{1}", servo_x, servo_y);
                */
            }
        }

        public void openPort()
        {
            if(!port.IsOpen)
            {
                port.Open();
            }
        }

        public void writeToPortUnparsed(Point coordinates)
        {
            port.Write(String.Format("X{0}Y{1}", coordinates.X, coordinates.Y));   
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

        private void btn_up_Click(object sender, EventArgs e)
        {

        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            
        }

        private void bnt_right_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
