using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinScreenKey
{
    public partial class MainWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private static KeyboardListener _keyboardListener;

        private Banner banner;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainBanner_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;

            this.splitter1.BackColor = Color.LightSlateGray;
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_24_1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_24;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.icons8_minimize_window_24_1;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.icons8_minimize_window_24;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _keyboardListener = new KeyboardListener();

            _keyboardListener.OnKeyReceived += KeyboardListenerOnOnKeyReceived;
            
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void KeyboardListenerOnOnKeyReceived(KeyPressEventArgs keyeventargs)
        {
            if (banner == null)
            {
                this.banner = new Banner(keyeventargs);

                this.banner.FormClosed += (o, eventArgs) =>
                    {
                        this.banner = null;
                    };

                banner.Show(this);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (banner != null)
            {
                banner.Close();
                banner = null;
            }

            _keyboardListener.OnKeyReceived -= KeyboardListenerOnOnKeyReceived;

            _keyboardListener = null;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
