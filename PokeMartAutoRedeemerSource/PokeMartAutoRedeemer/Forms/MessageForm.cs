using System;
using System.Windows.Forms;
using PokeMartAutoRedeemer.General;

namespace PokeMartAutoRedeemer.Forms
{
    public partial class MessageForm : Form
    {
        #region Private Fields

        private readonly bool _closeApplication;

        #endregion

        #region Constructor

        public MessageForm(string message, string title = "Error", bool closeApplication = false)
        {
            InitializeComponent();
            this.alertMessage.Text = message;
            this.titleLabel.Text = title;
            this._closeApplication = closeApplication;
        }

        #endregion

        #region  Private Methods

        private void CloseIconClick(object sender, EventArgs e)
        {
            if (_closeApplication)
            {
                Environment.Exit(0);
            }
            this.Dispose();
        }

        private void TopBarMouseMove(object sender, MouseEventArgs e)
        {
            Global.TopBarMouseMove(Handle, sender, e);
        }

        #endregion
    }
}
