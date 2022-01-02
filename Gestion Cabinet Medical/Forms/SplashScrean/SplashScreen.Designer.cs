namespace Gestion_Cabinet_Medical.Forms.SplashScrean
{
    partial class SplashScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDownloadData = new System.Windows.Forms.Label();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.txtDownloadData);
            this.panel1.Controls.Add(this.marqueeProgressBarControl1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 288);
            this.panel1.TabIndex = 1;
            // 
            // txtDownloadData
            // 
            this.txtDownloadData.AutoSize = true;
            this.txtDownloadData.BackColor = System.Drawing.Color.Transparent;
            this.txtDownloadData.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloadData.Location = new System.Drawing.Point(12, 236);
            this.txtDownloadData.Name = "txtDownloadData";
            this.txtDownloadData.Size = new System.Drawing.Size(117, 21);
            this.txtDownloadData.TabIndex = 4;
            this.txtDownloadData.Text = "Download Data";
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(12, 260);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.marqueeProgressBarControl1.Properties.Appearance.ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.marqueeProgressBarControl1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.marqueeProgressBarControl1.Properties.AppearanceReadOnly.ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.marqueeProgressBarControl1.Properties.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.marqueeProgressBarControl1.Properties.MarqueeAnimationSpeed = 60;
            this.marqueeProgressBarControl1.Properties.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(348, 15);
            this.marqueeProgressBarControl1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Cabinet_Medical.Properties.Resources.pexels_anna_shvets_3786157;
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 288);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private System.Windows.Forms.Label txtDownloadData;
    }
}