using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinScreenKey
{
    public partial class Banner : Form
    {
        private Timer timer;
        private Timer resetTimer;
        private Timer closeTimer;
        private KeyPressEventArgs _args;
        private static KeyboardListener _keyboardListener;

        public Banner()
        {
            InitializeComponent();
        }

        public Banner(KeyPressEventArgs args)
        {
            this._args = args;
            InitializeComponent();
        }

        private void Banner_Load(object sender, EventArgs e)
        {
            var screen = GetScreen();
            this.Width = screen.Width;
            this.Location = new Point(0, screen.Height - (this.Height + 50));
            this.Opacity = 0;
            timer = new Timer { Interval = 10 };
            timer.Tick += ChangeOpacity;
            timer.Start();

            lblKeys.Text = string.Empty;

            resetTimer = new Timer { Interval = 2000 };

            resetTimer.Tick += (o, args) =>
                {
                    lblKeys.Text = string.Empty;
                    resetTimer.Stop();
                };

            closeTimer = new Timer { Interval = 7000 };

            closeTimer.Tick += (o, args) =>
                {
                    this.Close();
                };

            Updatekey(_args.KeyChar);
            _keyboardListener = new KeyboardListener();

            _keyboardListener.OnKeyReceived += arg =>
                {
                    resetTimer.Stop();
                    closeTimer.Stop();
                    Updatekey(arg.KeyChar);
                    resetTimer.Start();
                    closeTimer.Start();
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
                timer.Stop();
            }
        }

        public Rectangle GetScreen()
        {
            return Screen.FromControl(this).Bounds;
        }

        private void Updatekey(char keyCode) {

            if (keyCode == (char)Keys.Back && lblKeys.Text.Length >= 1)
            {
                lblKeys.Text = lblKeys.Text.Substring(0, lblKeys.Text.Length - 1);

                return;
            }

            lblKeys.Text += keyCode.ToString();
        }
    }
}
