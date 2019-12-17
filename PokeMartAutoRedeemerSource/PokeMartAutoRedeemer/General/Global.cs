using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PokeMartAutoRedeemer.Forms;

namespace PokeMartAutoRedeemer.General
{
    public static class Global
    {

        #region Public Fields

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        public const int MouseeventfLeftdown = 0x02;
        public const int MouseeventfLeftup = 0x04;

        public enum Mode
        {
            Next,
            Previous
        }

        #endregion

        #region Public Methods

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public static void TopBarMouseMove(IntPtr handle, object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(handle, WmNclbuttondown, HtCaption, 0);
        }

        public static void ShowMessage(string message, string title = "Error", bool closeApplication = false)
        {
            var form = new MessageForm(message, title, closeApplication);
            form.Show();
        }

        public static void SimulateClick(int x, int y)
        {
            Cursor.Position = new Point(x, y);
            mouse_event(MouseeventfLeftdown | MouseeventfLeftup, (uint)x, (uint)y, 0, 0);
        }

        #endregion
    }
}
