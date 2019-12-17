using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using LowLevelHooking;
using PokeMartAutoRedeemer.General;

namespace PokeMartAutoRedeemer.Forms
{
    public partial class MainForm : Form
    {
        #region Private Fields
        
        private Dictionary<int, bool> pageList = new Dictionary<int, bool>
        {
            {1, true},
            {2, false},
            {3, false},
            {4, false}
        };

        private Dictionary<int, Dictionary<string, string>> _screenDictionary;

        private int _currentDisplay;

        private bool _isControlPressed;

        private bool _isSPressed;

        private bool _isApplicationRunning;

        private int _currentPage = 1;

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
            AddLowLevelHook();
            AddResources();
            GetMonitorInformation();

            // A bit ugly, but needed to have a proper splash screen
            var done = false;
            ThreadPool.QueueUserWorkItem((x) =>
            {
                using var splashForm = new SplashForm();
                splashForm.Show();
                while (!done)
                    Application.DoEvents();
                splashForm.Close();
            });

            Thread.Sleep(2000);
            done = true;
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        #endregion

        #region Private Methods

        private void AddLowLevelHook()
        {
            // Low level hook
            Program.GlobalKeyboardHook.KeyDownOrUp += OnGlobalKeyDownOrUp;
            Disposed += OnMainViewDisposed;
        }

        private void AddResources()
        {
            // .NET Core 3.1 for Windows forms is a bit buggy. This is here as a failsafe.
            this.Icon = Properties.Resources.pokemart_logo_icon1;
            this.monitor.Image = Properties.Resources.monitor;
            this.displayLeftArrow.Image = Properties.Resources.leftarrow;
            this.displayRightArrow.Image = Properties.Resources.rightarrow;
            this.pageLeftArrow.Image = Properties.Resources.leftarrow;
            this.pageRightArrow.Image = Properties.Resources.rightarrow;
            this.step1.Image = Properties.Resources.step_selected;
            this.step2.Image = Properties.Resources.step_deselected;
            this.step3.Image = Properties.Resources.step_deselected;
            this.step4.Image = Properties.Resources.step_deselected;

            this.page2.Location = new Point(1, 50);
            this.page3.Location = new Point(1, 50);
            this.page4.Location = new Point(1, 50);

            // Because I keep the pages next to each other in the designer (easier to design that way), we need to adjust the width of the form programmatically.
            this.Width = 400;
        }

        private void GetMonitorInformation()
        {
            // Fetch monitor information
            this._screenDictionary = new Dictionary<int, Dictionary<string, string>>();
            var i = 1;

            foreach (var screen in Screen.AllScreens)
            {
                var tempDictionary = new Dictionary<string, string>
                {
                    {"Display: ", screen.DeviceName.Replace("\\\\.\\", "")},
                    {"Resolution: ", screen.Bounds.Width + "x" + screen.Bounds.Height},
                    {
                        "Area X: ",
                        screen.WorkingArea.X + " PX - " + (screen.WorkingArea.X + screen.WorkingArea.Width) + "PX"
                    },
                    {
                        "Area Y: ",
                        screen.WorkingArea.Y + " PX - " + (screen.WorkingArea.Y + screen.WorkingArea.Height) + "PX"
                    },
                    {"Main display? ", screen.Primary ? "Yes" : "No"}
                };

                if (screen.Primary)
                {
                    ShowMonitorInformationOnForm(tempDictionary);
                    this._currentDisplay = i;
                }

                this._screenDictionary.Add(i, tempDictionary);
                i++;
            }
        }

        private void ShowMonitorInformationOnForm(Dictionary<string, string> dictionary)
        {
            var stringBuilderLeft = string.Empty;
            var stringBuilderRight = string.Empty;

            foreach (var (key, value) in dictionary)
            {
                stringBuilderLeft += key + Environment.NewLine;
                stringBuilderRight += value + Environment.NewLine;
            }

            this.screenLabelLeft.Text = stringBuilderLeft;
            this.screenLabelRight.Text = stringBuilderRight;
        }

        private void OnMainViewDisposed(object sender, EventArgs e)
        {
            // In the unique event the form lifetime is shorter than the application's...
            Program.GlobalKeyboardHook.KeyDownOrUp -= OnGlobalKeyDownOrUp;
        }

        private void OnGlobalKeyDownOrUp(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (this._currentPage != 4)
            {
                return;
            }

            if (e.KeyCode == VirtualKey.Escape)
            {
                Environment.Exit(0);
            }

            if (e.KeyCode != VirtualKey.LeftControl && e.KeyCode != VirtualKey.S) return;

            switch (e.KeyCode)
            {
                case VirtualKey.LeftControl:
                    this._isControlPressed = e.IsUp;
                    break;
                case VirtualKey.S:
                    this._isSPressed = e.IsUp;
                    break;
            }

            if (!this._isControlPressed || !this._isSPressed) return;

            if (_isApplicationRunning)
            {
                return;
            }

            this._isApplicationRunning = true;
            this.AdvancedScreenClicker();
            this._isApplicationRunning = false;
        }

        #region Form events

        private void CloseIconClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopBarMouseMove(object sender, MouseEventArgs e)
        {
            Global.TopBarMouseMove(Handle, sender, e);
        }

        private void RedeemImageClick(object sender, EventArgs e)
        {
            var form = new ImageForm(Properties.Resources.ptcgo_screen);
            form.Show();
        }

        private void DonorBoxClick(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://www.donorbox.org/auriorx/");
        }

        #endregion

        #region Switches

        /* Display Switch */
        private void DisplayLeftArrowClick(object sender, EventArgs e)
        {
            SwitchDisplay(Global.Mode.Previous);
        }

        private void DisplayRightArrowClick(object sender, EventArgs e)
        {
            SwitchDisplay(Global.Mode.Next);
        }

        private void SwitchDisplay(Global.Mode mode)
        {
            var nextNumber = (mode == Global.Mode.Next ? this._currentDisplay + 1 : this._currentDisplay - 1);

            if (nextNumber < this._screenDictionary.Min(x => x.Key))
            {
                nextNumber = this._screenDictionary.Max(x => x.Key);
            }

            if (nextNumber > this._screenDictionary.Max(x => x.Key))
            {
                nextNumber = this._screenDictionary.Min(x => x.Key);
            }

            this._currentDisplay = nextNumber;
            this.displayNumberLabel.Text = this._currentDisplay.ToString();

            ShowMonitorInformationOnForm(this._screenDictionary.First(x => x.Key == nextNumber).Value);
        }

        /* Page Switch */
        private void PageLeftArrowClick(object sender, EventArgs e)
        {
            SwitchPage(Global.Mode.Previous);
        }

        private void PageRightArrowClick(object sender, EventArgs e)
        {
            SwitchPage(Global.Mode.Next);
        }

        private void SwitchPage(Global.Mode mode)
        {
            if (_isApplicationRunning)
            {
                return;
            }

            var nextNumber = (mode == Global.Mode.Next ? this._currentPage + 1 : this._currentPage - 1);

            if (nextNumber < this.pageList.Min(x => x.Key) || nextNumber > this.pageList.Max(x => x.Key))
            {
                nextNumber = this._currentPage;
            }

            this._currentPage = nextNumber;

            var tempDict = new Dictionary<int, bool>();

            foreach (var page in pageList)
            {
                if (page.Key == this._currentPage)
                {
                    tempDict.Add(page.Key, true);
                    continue;
                }

                tempDict.Add(page.Key, false);
            }

            this.pageList = tempDict;

            this.step1.Image = this.pageList.First(x => x.Key == 1).Value ? Properties.Resources.step_selected : Properties.Resources.step_deselected;
            this.step2.Image = this.pageList.First(x => x.Key == 2).Value ? Properties.Resources.step_selected : Properties.Resources.step_deselected;
            this.step3.Image = this.pageList.First(x => x.Key == 3).Value ? Properties.Resources.step_selected : Properties.Resources.step_deselected;
            this.step4.Image = this.pageList.First(x => x.Key == 4).Value ? Properties.Resources.step_selected : Properties.Resources.step_deselected;

            this.page1.Visible = this.pageList.First(x => x.Key == 1).Value;
            this.page2.Visible = this.pageList.First(x => x.Key == 2).Value;
            this.page3.Visible = this.pageList.First(x => x.Key == 3).Value;
            this.page4.Visible = this.pageList.First(x => x.Key == 4).Value;
        }

        #endregion

        #region MouseOvers

        /* Display Mouseover */
        private void DisplayLeftArrowMouseEnter(object sender, EventArgs e)
        {
            this.displayLeftArrow.Image = Properties.Resources.leftarrow_hover;
        }

        private void DisplayLeftArrowMouseLeave(object sender, EventArgs e)
        {
            this.displayLeftArrow.Image = Properties.Resources.leftarrow;
        }

        private void DisplayRightArrowMouseEnter(object sender, EventArgs e)
        {
            this.displayRightArrow.Image = Properties.Resources.rightarrow_hover;
        }

        private void DisplayRightArrowMouseLeave(object sender, EventArgs e)
        {
            this.displayRightArrow.Image = Properties.Resources.rightarrow;
        }

        /* Page Mouseover */
        private void PageLeftArrowMouseEnter(object sender, EventArgs e)
        {
            this.pageLeftArrow.Image = Properties.Resources.leftarrow_hover;
        }

        private void PageLeftArrowMouseLeave(object sender, EventArgs e)
        {
            this.pageLeftArrow.Image = Properties.Resources.leftarrow;
        }

        private void PageRightArrowMouseEnter(object sender, EventArgs e)
        {
            this.pageRightArrow.Image = Properties.Resources.rightarrow_hover;
        }

        private void PageRightArrowMouseLeave(object sender, EventArgs e)
        {
            this.pageRightArrow.Image = Properties.Resources.rightarrow;
        }

        #endregion

        #region ScreenClicker

        private void AdvancedScreenClicker()
        {
            if (string.IsNullOrWhiteSpace(this.codeList.Text))
            {
                Global.ShowMessage("No codes provided.");
            }

            if (this._screenDictionary.Count == 1)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            // Get screen information and corresponding step information
            var screen = this._screenDictionary.First(x => x.Key == this._currentDisplay).Value;
            var resolution = screen.DefaultIfEmpty(new KeyValuePair<string, string>("0", "0x0")).First(x => x.Key.Equals("Resolution: ")).Value;
            var workingAreaX = int.Parse(screen.DefaultIfEmpty(new KeyValuePair<string, string>("0", "0")).First(x => x.Key.Equals("Area X: ")).Value.Split("-")[0].Replace(" ", "").Replace("PX", ""));
            var workingAreaY = int.Parse(screen.DefaultIfEmpty(new KeyValuePair<string, string>("0", "0")).First(x => x.Key.Equals("Area Y: ")).Value.Split("-")[0].Replace(" ", "").Replace("PX", ""));
            var stepInfo = Resolution.ResolutionStepDictionary.First(x => x.Key.Equals(resolution)).Value;

            // Get codes
            var codes = new List<string>();
            codes.AddRange(new List<string>(this.codeList.Text.Split(new string[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries)).Where(code => !code.Equals(string.Empty)));
            this.redeemProgress.Value = 0;
            this.redeemProgress.Maximum = codes.Count;

            var codeRedeemerCount = 0;
            Thread.Sleep(500);
            foreach (var code in codes)
            {
                // Click on the box where we insert the code
                Global.SimulateClick(stepInfo.First(x => x.Key.Equals("clickOnCodeBox")).Value.x + workingAreaX, stepInfo.First(x => x.Key.Equals("clickOnCodeBox")).Value.y + workingAreaY);
                Thread.Sleep(250);

                // Type the code
                SendKeys.Send(code);
                Thread.Sleep(250);

                // Click on the box to add the code
                Global.SimulateClick(stepInfo.First(x => x.Key.Equals("clickOnAddCode")).Value.x + workingAreaX, stepInfo.First(x => x.Key.Equals("clickOnAddCode")).Value.y + workingAreaY);
                Thread.Sleep(250);

                // In case of duplicates, always try to dismiss the error so we can always continue to the next code
                Global.SimulateClick(stepInfo.First(x => x.Key.Equals("clickOnDuplicateErrorOkButton")).Value.x + workingAreaX, stepInfo.First(x => x.Key.Equals("clickOnDuplicateErrorOkButton")).Value.y + workingAreaY);
                Thread.Sleep(750);

                codeRedeemerCount++;

                if (codeRedeemerCount == 10 || this.redeemProgress.Value + this.redeemProgress.Step == this.redeemProgress.Maximum)
                {
                    // Handle submitting codeCount
                    Global.SimulateClick(stepInfo.First(x => x.Key.Equals("clickOnSubmitCodes")).Value.x + workingAreaX, stepInfo.First(x => x.Key.Equals("clickOnSubmitCodes")).Value.y + workingAreaY);
                    Thread.Sleep(1000);
                    Global.SimulateClick(stepInfo.First(x => x.Key.Equals("clickOnSubmitCodesDoneButton")).Value.x + workingAreaX, stepInfo.First(x => x.Key.Equals("clickOnSubmitCodesDoneButton")).Value.y + workingAreaY);
                    Thread.Sleep(500);
                }

                this.redeemProgress.PerformStep();
            }

            this.Show();
            this.WindowState = FormWindowState.Normal;

            Global.ShowMessage("Pokémart AutoRedeemer has finished.", "Done!");
        }

        #endregion

        #endregion
    }
}
