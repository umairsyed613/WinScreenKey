using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinScreenKey
{
    public partial class Banner : Form
    {
        private Timer _timer;
        private Timer _resetTimer;
        private Timer _closeTimer;
        private KeyPressEventArgs _args;
        private static KeyboardListener _keyboardListener;
        private readonly BannerConfigruation _bannerConfigruation;

        public Banner()
        {
            InitializeComponent();
        }

        public Banner(KeyPressEventArgs args, BannerConfigruation bannerConfigruation)
        {
            _args = args;
            _bannerConfigruation = bannerConfigruation;
            InitializeComponent();
        }

        private void Banner_Load(object sender, EventArgs e)
        {
            if (_bannerConfigruation != null)
            {
                lblKeys.Font = _bannerConfigruation.Font;
                lblKeys.ForeColor = _bannerConfigruation.ForegroundColor;
                BackColor = _bannerConfigruation.BackgroundColor;
                Height = _bannerConfigruation.Height;
            }

            var screen = GetScreen();
            Width = screen.Width;
            Location = new Point(0, screen.Height - (Height + 50));

            // Opacity
            Opacity = 0;
            _timer = new Timer { Interval = 10 };
            _timer.Tick += ChangeOpacity;
            _timer.Start();

            // opacity End

            lblKeys.Text = string.Empty;

            _resetTimer = new Timer { Interval = _bannerConfigruation?.TextClearTimeOut ?? 2000 };

            _resetTimer.Tick += (o, args) =>
                {
                    lblKeys.Text = string.Empty;
                    _resetTimer.Stop();
                };

            _closeTimer = new Timer { Interval = _bannerConfigruation?.BannerCloseTimeOut ?? 7000 };

            _closeTimer.Tick += (o, args) =>
                {
                    this.Close();
                };

            Updatekey(_args.KeyChar);
            _keyboardListener = new KeyboardListener();

            _keyboardListener.OnKeyReceived += arg =>
                {
                    _resetTimer.Stop();
                    _closeTimer.Stop();
                    Updatekey(arg.KeyChar);
                    _resetTimer.Start();
                    _closeTimer.Start();
                };

            _keyboardListener.OnSpecialKeyReceived += args =>
                {
                    lblKeys.Text += args.KeyData.ToString();
                };

        }

        void ChangeOpacity(object sender, EventArgs e)
        {
            this.Opacity += .05; // replace.10 with whatever you want

            if (this.Opacity >= 0.8)
            {
                _timer.Stop();
            }
        }

        public Rectangle GetScreen()
        {
            return Screen.FromControl(this).Bounds;
        }

        private void Updatekey(char keyCode)
        {
            if (keyCode == (char)Keys.Enter)
            {
                return;
            }

            if (keyCode == (char)Keys.Back && lblKeys.Text.Length >= 1)
            {
                lblKeys.Text = lblKeys.Text.Substring(0, lblKeys.Text.Length - 1);

                return;
            }

            lblKeys.Text += keyCode.ToString();
        }
    }
}
