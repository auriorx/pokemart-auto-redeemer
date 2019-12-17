using System;
using System.Windows.Forms;
using LowLevelHooking;
using PokeMartAutoRedeemer.Forms;

namespace PokeMartAutoRedeemer
{
    public static class Program
    {
        public static GlobalKeyboardHook GlobalKeyboardHook { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (GlobalKeyboardHook = new GlobalKeyboardHook())
            {
                Application.Run(new MainForm());
            }
            
        }
    }
}
