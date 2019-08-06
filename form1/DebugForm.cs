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
using System.IO.Ports;

namespace form1
{
    public partial class DebugForm : Form
    {
        public Stopwatch watch { get; set; }
        SerialPort port;

        bool isMouseMoveActive = false;

        public DebugForm(SerialPort port)
        {
            InitializeComponent();
            this.port = port;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            watch = Stopwatch.StartNew();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseMoveActive)
                writeToPort(new Point(e.X, e.Y));
        }

        public void writeToPort(Point coordinates)
        {
            if (watch.ElapsedMilliseconds > 15)
            {
                watch = Stopwatch.StartNew();

                int x = (180 - coordinates.X / (Size.Width / 180));
                int y = (180 - coordinates.Y / (Size.Height / 180));

                port.Write(String.Format("X{0}Y{1}", x, y));

                lbl_mouseCoords.Text = String.Format("MOUSE COORDS: X:{0}Y:{1}", coordinates.X, coordinates.Y);
                lbl_sentCoords.Text =  String.Format("SENT COORDS: X:{0}Y:{1}", x, y);
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (isMouseMoveActive)
                Cursor.Clip = this.Bounds;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            port.Write("X" + textbox_x.Text + "Y" + textbox_y.Text);
        }

        private void DebugForm_MouseClick(object sender, MouseEventArgs e)
        {
            isMouseMoveActive = !isMouseMoveActive;
            lbl_mouseActive.Text = (isMouseMoveActive) ? "MOUSE ACTIVE" : "MOUSE INACTIVE";
        }
    }
}
