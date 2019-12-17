using System;
using System.Drawing;
using System.Windows.Forms;
using PokeMartAutoRedeemer.General;

namespace PokeMartAutoRedeemer.Forms
{
    public partial class ImageForm : Form
    {
        #region Constructor

        public ImageForm(Image imageToOpen)
        {
            InitializeComponent();
            SetResources(imageToOpen);
        }

        #endregion

        #region Private Methods

        private void SetResources(Image imageToOpen)
        {
            this.Icon = Properties.Resources.pokemart_logo_icon1;
            this.Height = imageToOpen.Height + this.panel1.Height;
            this.Width = imageToOpen.Width;
            this.imageBox.Image = imageToOpen;
        }

        private void CloseIconClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopBarMouseMove(object sender, MouseEventArgs e)
        {
            Global.TopBarMouseMove(Handle, sender, e);
        }

        #endregion
    }
}
