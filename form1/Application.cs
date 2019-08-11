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
        List<String> detectables = new List<string>() { "Circle", "Square" };

        Capture capture;
        Image<Bgr, Byte> originalImage;
        List<Image<Bgr, Byte>> images_detected;

        Stopwatch watch { get; set; }
        String read_serial;

        String servo_x;
        String servo_y;

        bool isDetecting = false;

        public Application()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openPort();
            writeToPortUnparsed(new Point(80, 80));

            foreach (String detectable in detectables)
                combobox_detecting.Items.Add(detectable);
            combobox_detecting.SelectedIndex = 0;


            watch = Stopwatch.StartNew();

            try
            {
                capture = new Emgu.CV.Capture();

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
            originalImage = capture.QueryFrame().ToImage<Bgr, Byte>().Resize(imgbox_video.Size.Width, imgbox_video.Size.Height, Inter.Nearest);
            imgbox_video.Image = originalImage;

            //detection video
            switch(combobox_detecting.Text)
            {
                case "Circle":
                    detectCircle();
                break;
                default:
                    noDetections();
                break;
            }

            //get laser angle
            readSerialData();
        }

        private void readSerialData()
        {
            read_serial = port.ReadExisting().ToString().Replace(Environment.NewLine, "");
            if (read_serial.Length > 2)
            {
                try
                {
                    servo_x = read_serial.Substring(0, read_serial.IndexOf("Y")).Substring(1);
                    servo_y = read_serial.Substring(read_serial.IndexOf("Y")).Substring(1);
                    lbl_laserAngle.Text = String.Format("Laser Coords: {{X={0} Y={1}}}", servo_x, servo_y);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void detectCircle()
        {
            images_detected = Detector.DrawCircle(originalImage, lbl_circlepoint);
            imgbox_detection1.Image = images_detected[0].Resize(imgbox_detection1.Size.Width, imgbox_detection1.Size.Height, Inter.Nearest);
            imgbox_detection2.Image = images_detected[1].Resize(imgbox_detection2.Size.Width, imgbox_detection2.Size.Height, Inter.Nearest);
        }

        private void noDetections()
        {
            imgbox_detection1.Image = originalImage.Resize(imgbox_detection1.Size.Width, imgbox_detection1.Size.Height, Inter.Nearest);
            imgbox_detection2.Image = originalImage.Resize(imgbox_detection2.Size.Width, imgbox_detection2.Size.Height, Inter.Nearest).CopyBlank();
        }

        public void writeToPortUnparsed(Point point)
        {
            port.Write(String.Format("X{0}Y{1}", point.X, point.Y));
        }

        public void openPort()
        {
            if(!port.IsOpen)
                port.Open();
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
