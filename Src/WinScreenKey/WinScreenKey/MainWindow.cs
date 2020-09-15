using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Gma.System.MouseKeyHook;

using Microsoft.Win32;

namespace WinScreenKey
{
    public partial class MainWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainBanner_Load(object sender, EventArgs e)
        {
           HookEvents();
           var banner = new Banner();
           banner.Show(this);
        }

        private void HookEvents()
        {
            Hook.GlobalEvents().KeyDown += (sender, e) => lblKeys.Text += e.KeyData.ToString() + " + ";
        }
    }
}
