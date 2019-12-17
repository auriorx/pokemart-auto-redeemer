namespace PokeMartAutoRedeemer.Forms
{
    partial class ImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.miniLogo = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miniLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.miniLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 49);
            this.panel1.TabIndex = 2;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseMove);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Panton Black Caps", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(39, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(190, 20);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "PokeMart Auto Redeemer";
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseMove);
            // 
            // miniLogo
            // 
            this.miniLogo.Image = ((System.Drawing.Image)(resources.GetObject("miniLogo.Image")));
            this.miniLogo.Location = new System.Drawing.Point(10, 15);
            this.miniLogo.Name = "miniLogo";
            this.miniLogo.Size = new System.Drawing.Size(20, 20);
            this.miniLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.miniLogo.TabIndex = 5;
            this.miniLogo.TabStop = false;
            this.miniLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseMove);
            // 
            // closeIcon
            // 
            this.closeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeIcon.Image = ((System.Drawing.Image)(resources.GetObject("closeIcon.Image")));
            this.closeIcon.Location = new System.Drawing.Point(39, 15);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(17, 18);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeIcon.TabIndex = 1;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.CloseIconClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(201, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeIcon);
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(691, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 49);
            this.panel2.TabIndex = 4;
            // 
            // imageBox
            // 
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(0, 49);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(759, 751);
            this.imageBox.TabIndex = 4;
            this.imageBox.TabStop = false;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 800);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.miniLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox miniLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imageBox;
    }
}