namespace form1
{
    partial class Application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.btn_capture = new System.Windows.Forms.Button();
            this.imgbox_video = new Emgu.CV.UI.ImageBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_cameraDimensions = new System.Windows.Forms.Label();
            this.imgbox_detection = new Emgu.CV.UI.ImageBox();
            this.lbl_circlepoint = new System.Windows.Forms.Label();
            this.lbl_laserAngle = new System.Windows.Forms.Label();
            this.btn_sendCoords = new System.Windows.Forms.Button();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.textbox_x = new System.Windows.Forms.TextBox();
            this.textbox_y = new System.Windows.Forms.TextBox();
            this.bnt_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.lbl_manualMove = new System.Windows.Forms.Label();
            this.lbl_degrees = new System.Windows.Forms.Label();
            this.numericUpDown_degrees = new System.Windows.Forms.NumericUpDown();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_debug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_detection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_degrees)).BeginInit();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.PortName = "COM5";
            // 
            // btn_capture
            // 
            this.btn_capture.Location = new System.Drawing.Point(13, 646);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(75, 23);
            this.btn_capture.TabIndex = 4;
            this.btn_capture.Text = "CAPTURE";
            this.btn_capture.UseVisualStyleBackColor = true;
            // 
            // imgbox_video
            // 
            this.imgbox_video.Location = new System.Drawing.Point(12, 12);
            this.imgbox_video.Name = "imgbox_video";
            this.imgbox_video.Size = new System.Drawing.Size(640, 480);
            this.imgbox_video.TabIndex = 2;
            this.imgbox_video.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1247, 646);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_cameraDimensions
            // 
            this.lbl_cameraDimensions.AutoSize = true;
            this.lbl_cameraDimensions.Location = new System.Drawing.Point(12, 495);
            this.lbl_cameraDimensions.Name = "lbl_cameraDimensions";
            this.lbl_cameraDimensions.Size = new System.Drawing.Size(103, 13);
            this.lbl_cameraDimensions.TabIndex = 6;
            this.lbl_cameraDimensions.Text = "Camera Dimensions:";
            // 
            // imgbox_detection
            // 
            this.imgbox_detection.Location = new System.Drawing.Point(682, 12);
            this.imgbox_detection.Name = "imgbox_detection";
            this.imgbox_detection.Size = new System.Drawing.Size(640, 480);
            this.imgbox_detection.TabIndex = 7;
            this.imgbox_detection.TabStop = false;
            // 
            // lbl_circlepoint
            // 
            this.lbl_circlepoint.AutoSize = true;
            this.lbl_circlepoint.Location = new System.Drawing.Point(12, 517);
            this.lbl_circlepoint.Name = "lbl_circlepoint";
            this.lbl_circlepoint.Size = new System.Drawing.Size(72, 13);
            this.lbl_circlepoint.TabIndex = 8;
            this.lbl_circlepoint.Text = "Circle Coords:";
            // 
            // lbl_laserAngle
            // 
            this.lbl_laserAngle.AutoSize = true;
            this.lbl_laserAngle.Location = new System.Drawing.Point(12, 539);
            this.lbl_laserAngle.Name = "lbl_laserAngle";
            this.lbl_laserAngle.Size = new System.Drawing.Size(66, 13);
            this.lbl_laserAngle.TabIndex = 9;
            this.lbl_laserAngle.Text = "Laser Angle:";
            // 
            // btn_sendCoords
            // 
            this.btn_sendCoords.Location = new System.Drawing.Point(12, 646);
            this.btn_sendCoords.Name = "btn_sendCoords";
            this.btn_sendCoords.Size = new System.Drawing.Size(88, 23);
            this.btn_sendCoords.TabIndex = 10;
            this.btn_sendCoords.Text = "SEND";
            this.btn_sendCoords.UseVisualStyleBackColor = true;
            this.btn_sendCoords.Click += new System.EventHandler(this.btn_sendCoords_Click);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(12, 625);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(17, 13);
            this.lbl_x.TabIndex = 11;
            this.lbl_x.Text = "X:";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(57, 625);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(17, 13);
            this.lbl_y.TabIndex = 12;
            this.lbl_y.Text = "Y:";
            // 
            // textbox_x
            // 
            this.textbox_x.Location = new System.Drawing.Point(26, 622);
            this.textbox_x.Name = "textbox_x";
            this.textbox_x.Size = new System.Drawing.Size(27, 20);
            this.textbox_x.TabIndex = 13;
            this.textbox_x.Text = "80";
            // 
            // textbox_y
            // 
            this.textbox_y.Location = new System.Drawing.Point(73, 622);
            this.textbox_y.Name = "textbox_y";
            this.textbox_y.Size = new System.Drawing.Size(27, 20);
            this.textbox_y.TabIndex = 14;
            this.textbox_y.Text = "80";
            // 
            // bnt_right
            // 
            this.bnt_right.Location = new System.Drawing.Point(674, 568);
            this.bnt_right.Name = "bnt_right";
            this.bnt_right.Size = new System.Drawing.Size(54, 32);
            this.bnt_right.TabIndex = 17;
            this.bnt_right.Text = "RIGHT";
            this.bnt_right.UseVisualStyleBackColor = true;
            this.bnt_right.Click += new System.EventHandler(this.bnt_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(614, 568);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(54, 32);
            this.btn_left.TabIndex = 19;
            this.btn_left.Text = "LEFT";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(643, 606);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(54, 32);
            this.btn_down.TabIndex = 20;
            this.btn_down.Text = "DOWN";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(643, 530);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(54, 32);
            this.btn_up.TabIndex = 21;
            this.btn_up.Text = "UP";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // lbl_manualMove
            // 
            this.lbl_manualMove.AutoSize = true;
            this.lbl_manualMove.Location = new System.Drawing.Point(611, 508);
            this.lbl_manualMove.Name = "lbl_manualMove";
            this.lbl_manualMove.Size = new System.Drawing.Size(127, 13);
            this.lbl_manualMove.TabIndex = 22;
            this.lbl_manualMove.Text = "MANUAL LASER MOVE:";
            // 
            // lbl_degrees
            // 
            this.lbl_degrees.AutoSize = true;
            this.lbl_degrees.Location = new System.Drawing.Point(616, 656);
            this.lbl_degrees.Name = "lbl_degrees";
            this.lbl_degrees.Size = new System.Drawing.Size(50, 13);
            this.lbl_degrees.TabIndex = 24;
            this.lbl_degrees.Text = "Degrees:";
            // 
            // numericUpDown_degrees
            // 
            this.numericUpDown_degrees.Location = new System.Drawing.Point(672, 654);
            this.numericUpDown_degrees.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown_degrees.Name = "numericUpDown_degrees";
            this.numericUpDown_degrees.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown_degrees.TabIndex = 25;
            this.numericUpDown_degrees.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(106, 646);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(88, 23);
            this.btn_random.TabIndex = 26;
            this.btn_random.Text = "RANDOM";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_debug
            // 
            this.btn_debug.Location = new System.Drawing.Point(200, 646);
            this.btn_debug.Name = "btn_debug";
            this.btn_debug.Size = new System.Drawing.Size(75, 23);
            this.btn_debug.TabIndex = 27;
            this.btn_debug.Text = "DEBUG";
            this.btn_debug.UseVisualStyleBackColor = true;
            this.btn_debug.Click += new System.EventHandler(this.btn_debug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 681);
            this.Controls.Add(this.btn_debug);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.numericUpDown_degrees);
            this.Controls.Add(this.lbl_degrees);
            this.Controls.Add(this.lbl_manualMove);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.bnt_right);
            this.Controls.Add(this.textbox_y);
            this.Controls.Add(this.textbox_x);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.btn_sendCoords);
            this.Controls.Add(this.lbl_laserAngle);
            this.Controls.Add(this.lbl_circlepoint);
            this.Controls.Add(this.imgbox_detection);
            this.Controls.Add(this.lbl_cameraDimensions);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.imgbox_video);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_detection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_degrees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Button btn_capture;
        private Emgu.CV.UI.ImageBox imgbox_video;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_cameraDimensions;
        private Emgu.CV.UI.ImageBox imgbox_detection;
        private System.Windows.Forms.Label lbl_circlepoint;
        private System.Windows.Forms.Label lbl_laserAngle;
        private System.Windows.Forms.Button btn_sendCoords;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.TextBox textbox_x;
        private System.Windows.Forms.TextBox textbox_y;
        private System.Windows.Forms.Button bnt_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Label lbl_manualMove;
        private System.Windows.Forms.Label lbl_degrees;
        private System.Windows.Forms.NumericUpDown numericUpDown_degrees;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_debug;
    }
}

