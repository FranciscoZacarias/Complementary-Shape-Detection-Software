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
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_debug = new System.Windows.Forms.Button();
            this.btn_toggleDetect = new System.Windows.Forms.Button();
            this.combobox_detecting = new System.Windows.Forms.ComboBox();
            this.lbl_detectiong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_detection)).BeginInit();
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
            this.lbl_cameraDimensions.Size = new System.Drawing.Size(85, 13);
            this.lbl_cameraDimensions.TabIndex = 6;
            this.lbl_cameraDimensions.Text = "Cam Dimensions";
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
            this.lbl_y.Location = new System.Drawing.Point(54, 626);
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
            this.textbox_y.Location = new System.Drawing.Point(71, 623);
            this.textbox_y.Name = "textbox_y";
            this.textbox_y.Size = new System.Drawing.Size(27, 20);
            this.textbox_y.TabIndex = 14;
            this.textbox_y.Text = "80";
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
            this.btn_debug.Location = new System.Drawing.Point(106, 620);
            this.btn_debug.Name = "btn_debug";
            this.btn_debug.Size = new System.Drawing.Size(88, 23);
            this.btn_debug.TabIndex = 27;
            this.btn_debug.Text = "DEBUG";
            this.btn_debug.UseVisualStyleBackColor = true;
            this.btn_debug.Click += new System.EventHandler(this.btn_debug_Click);
            // 
            // btn_toggleDetect
            // 
            this.btn_toggleDetect.BackColor = System.Drawing.Color.Tomato;
            this.btn_toggleDetect.Location = new System.Drawing.Point(200, 620);
            this.btn_toggleDetect.Name = "btn_toggleDetect";
            this.btn_toggleDetect.Size = new System.Drawing.Size(88, 49);
            this.btn_toggleDetect.TabIndex = 28;
            this.btn_toggleDetect.Text = "TOGGLE DETECTION";
            this.btn_toggleDetect.UseVisualStyleBackColor = false;
            this.btn_toggleDetect.Click += new System.EventHandler(this.btn_toggleDetect_Click);
            // 
            // combobox_detecting
            // 
            this.combobox_detecting.FormattingEnabled = true;
            this.combobox_detecting.Location = new System.Drawing.Point(741, 502);
            this.combobox_detecting.Name = "combobox_detecting";
            this.combobox_detecting.Size = new System.Drawing.Size(96, 21);
            this.combobox_detecting.TabIndex = 29;
            // 
            // lbl_detectiong
            // 
            this.lbl_detectiong.AutoSize = true;
            this.lbl_detectiong.Location = new System.Drawing.Point(679, 505);
            this.lbl_detectiong.Name = "lbl_detectiong";
            this.lbl_detectiong.Size = new System.Drawing.Size(56, 13);
            this.lbl_detectiong.TabIndex = 30;
            this.lbl_detectiong.Text = "Detecting:";
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 681);
            this.Controls.Add(this.lbl_detectiong);
            this.Controls.Add(this.combobox_detecting);
            this.Controls.Add(this.btn_toggleDetect);
            this.Controls.Add(this.btn_debug);
            this.Controls.Add(this.btn_random);
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
            this.Name = "Application";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_detection)).EndInit();
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
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_debug;
        private System.Windows.Forms.Button btn_toggleDetect;
        private System.Windows.Forms.ComboBox combobox_detecting;
        private System.Windows.Forms.Label lbl_detectiong;
    }
}

