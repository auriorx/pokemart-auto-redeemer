namespace PokeMartAutoRedeemer.Forms
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.closeIconPanel = new System.Windows.Forms.Panel();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.miniLogo = new System.Windows.Forms.PictureBox();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.alertMessage = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.topBarPanel.SuspendLayout();
            this.closeIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLogo)).BeginInit();
            this.messagePanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.Black;
            this.topBarPanel.Controls.Add(this.closeIconPanel);
            this.topBarPanel.Controls.Add(this.titleLabel);
            this.topBarPanel.Controls.Add(this.miniLogo);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(1, 1);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(296, 49);
            this.topBarPanel.TabIndex = 2;
            this.topBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseMove);
            // 
            // closeIconPanel
            // 
            this.closeIconPanel.Controls.Add(this.closeIcon);
            this.closeIconPanel.Controls.Add(this.minimize);
            this.closeIconPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeIconPanel.Location = new System.Drawing.Point(228, 0);
            this.closeIconPanel.Name = "closeIconPanel";
            this.closeIconPanel.Size = new System.Drawing.Size(68, 49);
            this.closeIconPanel.TabIndex = 4;
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
            // minimize
            // 
            this.minimize.Location = new System.Drawing.Point(0, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(100, 50);
            this.minimize.TabIndex = 2;
            this.minimize.TabStop = false;
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
            this.titleLabel.Text = "Error";
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
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.messagePanel.Controls.Add(this.alertMessage);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagePanel.Location = new System.Drawing.Point(1, 50);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(296, 103);
            this.messagePanel.TabIndex = 7;
            // 
            // alertMessage
            // 
            this.alertMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.alertMessage.Font = new System.Drawing.Font("Panton Black Caps", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alertMessage.ForeColor = System.Drawing.Color.White;
            this.alertMessage.Location = new System.Drawing.Point(0, 0);
            this.alertMessage.Name = "alertMessage";
            this.alertMessage.Size = new System.Drawing.Size(296, 100);
            this.alertMessage.TabIndex = 0;
            this.alertMessage.Text = "label2";
            this.alertMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerPanel
            // 
            this.containerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerPanel.Controls.Add(this.messagePanel);
            this.containerPanel.Controls.Add(this.topBarPanel);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(1);
            this.containerPanel.Size = new System.Drawing.Size(300, 156);
            this.containerPanel.TabIndex = 8;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(300, 156);
            this.Controls.Add(this.containerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            this.TopMost = true;
            this.topBarPanel.ResumeLayout(false);
            this.closeIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLogo)).EndInit();
            this.messagePanel.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Panel closeIconPanel;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox miniLogo;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label alertMessage;
        private System.Windows.Forms.Panel containerPanel;
    }
}