namespace form1
{
    partial class DebugForm
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
            this.lbl_mouseCoords = new System.Windows.Forms.Label();
            this.lbl_sentCoords = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.llb_sendCoords = new System.Windows.Forms.Label();
            this.textbox_x = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.textbox_y = new System.Windows.Forms.TextBox();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_mouseActive = new System.Windows.Forms.Label();
            this.lbl_staticLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_mouseCoords
            // 
            this.lbl_mouseCoords.AutoSize = true;
            this.lbl_mouseCoords.Location = new System.Drawing.Point(12, 16);
            this.lbl_mouseCoords.Name = "lbl_mouseCoords";
            this.lbl_mouseCoords.Size = new System.Drawing.Size(98, 13);
            this.lbl_mouseCoords.TabIndex = 0;
            this.lbl_mouseCoords.Text = "MOUSE COORDS:";
            // 
            // lbl_sentCoords
            // 
            this.lbl_sentCoords.AutoSize = true;
            this.lbl_sentCoords.Location = new System.Drawing.Point(12, 43);
            this.lbl_sentCoords.Name = "lbl_sentCoords";
            this.lbl_sentCoords.Size = new System.Drawing.Size(86, 13);
            this.lbl_sentCoords.TabIndex = 1;
            this.lbl_sentCoords.Text = "SEND COORDS";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(678, 688);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(94, 61);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // llb_sendCoords
            // 
            this.llb_sendCoords.AutoSize = true;
            this.llb_sendCoords.Location = new System.Drawing.Point(12, 684);
            this.llb_sendCoords.Name = "llb_sendCoords";
            this.llb_sendCoords.Size = new System.Drawing.Size(106, 13);
            this.llb_sendCoords.TabIndex = 6;
            this.llb_sendCoords.Text = "Send Coords: (XnYn)";
            // 
            // textbox_x
            // 
            this.textbox_x.Location = new System.Drawing.Point(34, 700);
            this.textbox_x.Name = "textbox_x";
            this.textbox_x.Size = new System.Drawing.Size(30, 20);
            this.textbox_x.TabIndex = 7;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(12, 726);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(106, 23);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textbox_y
            // 
            this.textbox_y.Location = new System.Drawing.Point(88, 700);
            this.textbox_y.Name = "textbox_y";
            this.textbox_y.Size = new System.Drawing.Size(30, 20);
            this.textbox_y.TabIndex = 9;
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(70, 703);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(17, 13);
            this.lbl_y.TabIndex = 10;
            this.lbl_y.Text = "Y:";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(12, 703);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(17, 13);
            this.lbl_x.TabIndex = 11;
            this.lbl_x.Text = "X:";
            // 
            // lbl_mouseActive
            // 
            this.lbl_mouseActive.AutoSize = true;
            this.lbl_mouseActive.Location = new System.Drawing.Point(674, 9);
            this.lbl_mouseActive.Name = "lbl_mouseActive";
            this.lbl_mouseActive.Size = new System.Drawing.Size(98, 13);
            this.lbl_mouseActive.TabIndex = 12;
            this.lbl_mouseActive.Text = "MOUSE INACTIVE";
            // 
            // lbl_staticLabel
            // 
            this.lbl_staticLabel.AutoSize = true;
            this.lbl_staticLabel.Location = new System.Drawing.Point(566, 9);
            this.lbl_staticLabel.Name = "lbl_staticLabel";
            this.lbl_staticLabel.Size = new System.Drawing.Size(102, 13);
            this.lbl_staticLabel.TabIndex = 13;
            this.lbl_staticLabel.Text = "Left Click to Toggle:";
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.lbl_staticLabel);
            this.Controls.Add(this.lbl_mouseActive);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.textbox_y);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textbox_x);
            this.Controls.Add(this.llb_sendCoords);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_sentCoords);
            this.Controls.Add(this.lbl_mouseCoords);
            this.Name = "DebugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DebugForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_mouseCoords;
        private System.Windows.Forms.Label lbl_sentCoords;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label llb_sendCoords;
        private System.Windows.Forms.TextBox textbox_x;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textbox_y;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_mouseActive;
        private System.Windows.Forms.Label lbl_staticLabel;
    }
}