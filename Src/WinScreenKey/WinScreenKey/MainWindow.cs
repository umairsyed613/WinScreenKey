using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinScreenKey
{
    public partial class MainWindow : Form
    {
#pragma warning disable IDE1006 // Naming Styles
        public const int WM_NCLBUTTONDOWN = 0xA1;
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable IDE1006 // Naming Styles
        public const int HT_CAPTION = 0x2;
#pragma warning restore IDE1006 // Naming Styles

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private static KeyboardListener _keyboardListener;

        private Banner _banner;

        private static BannerConfigruation _bannerConfiguration;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainBanner_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
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


            btnStart.Visible = false;
            btnStop.Visible = true;
            lblStatus.Visible = true;
        }

        private void KeyboardListenerOnOnKeyReceived(KeyPressEventArgs keyeventargs)
        {
            if (_banner == null)
            {
                _banner = new Banner(keyeventargs, _bannerConfiguration);

                _banner.FormClosed += (o, eventArgs) =>
                    {
                        _banner = null;
                    };

                _banner.Show(this);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_banner != null)
            {
                _banner.Close();
                _banner = null;
            }

            _keyboardListener.OnKeyReceived -= KeyboardListenerOnOnKeyReceived;
            _keyboardListener = null;

            btnStart.Visible = true;
            btnStop.Visible = false;
            lblStatus.Visible = false;
        }

        private void btnStyleConfigure_Click(object sender, EventArgs e)
        {
            if (fontDlg.ShowDialog(this) != DialogResult.Cancel)
            {
                if (_bannerConfiguration != null)
                {
                    _bannerConfiguration.Font = fontDlg.Font;
                    _bannerConfiguration.ForegroundColor = fontDlg.Color;
                }
                else
                {
                    _bannerConfiguration = new BannerConfigruation { Font = fontDlg.Font, ForegroundColor = fontDlg.Color };
                }
            }
        }

        private void btnColorChooser_MouseDown(object sender, MouseEventArgs e)
        {
            if (colorDialog1.ShowDialog(this) != DialogResult.Cancel)
            {
                if (_bannerConfiguration != null)
                {
                    _bannerConfiguration.BackgroundColor = colorDialog1.Color;
                }
                else
                {
                    _bannerConfiguration = new BannerConfigruation { BackgroundColor = colorDialog1.Color };
                }

                btnColorChooser.BackColor = _bannerConfiguration.BackgroundColor;
            }
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void configGroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Silver, Color.Gray);
        }

        private void bannerHeightControl_ValueChanged(object sender, EventArgs e)
        {
            if (_bannerConfiguration != null)
            {
                _bannerConfiguration.Height = bannerHeightControl.Value;
            }
            else
            {
                _bannerConfiguration = new BannerConfigruation { Height = bannerHeightControl.Value };
            }

            lblBannerheight.Text = "Height (" + bannerHeightControl.Value + ")";
        }

        private void txtTextClearTimeOut_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(txtTextClearTimeOut.Text, out var val))
            {
                if (_bannerConfiguration != null)
                {
                    _bannerConfiguration.TextClearTimeOut = Convert.ToInt32(val * 1000);
                }
                else
                {
                    _bannerConfiguration = new BannerConfigruation { TextClearTimeOut = Convert.ToInt32(val * 1000) };
                }
            }
        }

        private void txtBannerCloseTimeOut_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(txtBannerCloseTimeOut.Text, out var val))
            {
                if (_bannerConfiguration != null)
                {
                    _bannerConfiguration.BannerCloseTimeOut = Convert.ToInt32(val * 1000);
                }
                else
                {
                    _bannerConfiguration = new BannerConfigruation { BannerCloseTimeOut = Convert.ToInt32(val * 1000) };
                }
            }
        }
    }
}
