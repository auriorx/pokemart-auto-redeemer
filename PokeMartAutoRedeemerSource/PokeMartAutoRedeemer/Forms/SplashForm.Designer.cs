namespace PokeMartAutoRedeemer.Forms
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.splashPanel = new System.Windows.Forms.Panel();
            this.splashImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splashPanel
            // 
            this.splashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.splashPanel.Controls.Add(this.splashImage);
            this.splashPanel.Location = new System.Drawing.Point(1, 1);
            this.splashPanel.Name = "splashPanel";
            this.splashPanel.Size = new System.Drawing.Size(598, 598);
            this.splashPanel.TabIndex = 0;
            // 
            // splashImage
            // 
            this.splashImage.Image = ((System.Drawing.Image)(resources.GetObject("splashImage.Image")));
            this.splashImage.Location = new System.Drawing.Point(1, 1);
            this.splashImage.Name = "splashImage";
            this.splashImage.Size = new System.Drawing.Size(598, 598);
            this.splashImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splashImage.TabIndex = 0;
            this.splashImage.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.splashPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.splashPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel splashPanel;
        private System.Windows.Forms.PictureBox splashImage;
        private System.Windows.Forms.Timer timer1;
    }
}