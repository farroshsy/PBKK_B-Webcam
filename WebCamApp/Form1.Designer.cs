namespace WebCamApp
{
    partial class Form1
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
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(165, 27);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(446, 24);
            this.cboCamera.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(33, 78);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(739, 345);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(33, 27);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(100, 32);
            this.lblCamera.TabIndex = 2;
            this.lblCamera.Text = "Camera";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(36, 482);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.cboCamera);
            this.Name = "Form1";
            this.Text = "Webcam PBKK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Button btnStart;
    }
}

