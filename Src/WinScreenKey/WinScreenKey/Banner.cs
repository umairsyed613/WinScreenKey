using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinScreenKey
{
    public partial class Banner : Form
    {
        private Timer timer;

        public Banner()
        {
            InitializeComponent();
        }

        private void Banner_Load(object sender, EventArgs e)
        {
            var screen = GetScreen();
            lblKeys.Text = screen.Height.ToString();
            this.Width = screen.Width;
            this.Location  = new Point(0, screen.Height - (this.Height + 50));
            this.Opacity = 0;

            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += ChangeOpacity;
            timer.Start();
        }

        void ChangeOpacity(object sender, EventArgs e)
        {
            this.Opacity += .05; //replace.10 with whatever you want

            if(this.Opacity >= 0.8)
            {
                timer.Stop();
            }
        }

        public Rectangle GetScreen()
        {
            return Screen.FromControl(this).Bounds;
        }
    }
}
