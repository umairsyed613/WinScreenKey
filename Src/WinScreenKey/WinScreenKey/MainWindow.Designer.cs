namespace WinScreenKey
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBannerheight = new System.Windows.Forms.Label();
            this.bannerHeightControl = new System.Windows.Forms.TrackBar();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.fontDlg = new System.Windows.Forms.FontDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColorChooser = new System.Windows.Forms.Panel();
            this.configGroupBox = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnStyleConfigure = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTextClearTimeOut = new System.Windows.Forms.TextBox();
            this.txtBannerCloseTimeOut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerHeightControl)).BeginInit();
            this.configGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStyleConfigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(69, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start / Stop Program";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(7, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 1);
            this.panel3.TabIndex = 8;
            // 
            // lblBannerheight
            // 
            this.lblBannerheight.AutoSize = true;
            this.lblBannerheight.Location = new System.Drawing.Point(8, 31);
            this.lblBannerheight.Name = "lblBannerheight";
            this.lblBannerheight.Size = new System.Drawing.Size(38, 13);
            this.lblBannerheight.TabIndex = 9;
            this.lblBannerheight.Text = "Height";
            // 
            // bannerHeightControl
            // 
            this.bannerHeightControl.Location = new System.Drawing.Point(105, 27);
            this.bannerHeightControl.Maximum = 400;
            this.bannerHeightControl.Minimum = 70;
            this.bannerHeightControl.Name = "bannerHeightControl";
            this.bannerHeightControl.Size = new System.Drawing.Size(253, 45);
            this.bannerHeightControl.SmallChange = 10;
            this.bannerHeightControl.TabIndex = 10;
            this.bannerHeightControl.TickFrequency = 10;
            this.bannerHeightControl.Value = 70;
            this.bannerHeightControl.ValueChanged += new System.EventHandler(this.bannerHeightControl_ValueChanged);
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(8, 81);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(62, 13);
            this.lblFontSize.TabIndex = 11;
            this.lblFontSize.Text = "Text Styling";
            // 
            // fontDlg
            // 
            this.fontDlg.Color = System.Drawing.Color.White;
            this.fontDlg.Font = new System.Drawing.Font("Calibri", 28F);
            this.fontDlg.ShowColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Background Color";
            // 
            // btnColorChooser
            // 
            this.btnColorChooser.BackColor = System.Drawing.Color.Black;
            this.btnColorChooser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorChooser.Location = new System.Drawing.Point(105, 116);
            this.btnColorChooser.Name = "btnColorChooser";
            this.btnColorChooser.Size = new System.Drawing.Size(23, 21);
            this.btnColorChooser.TabIndex = 14;
            this.btnColorChooser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnColorChooser_MouseDown);
            // 
            // configGroupBox
            // 
            this.configGroupBox.Controls.Add(this.label8);
            this.configGroupBox.Controls.Add(this.label7);
            this.configGroupBox.Controls.Add(this.txtBannerCloseTimeOut);
            this.configGroupBox.Controls.Add(this.txtTextClearTimeOut);
            this.configGroupBox.Controls.Add(this.label6);
            this.configGroupBox.Controls.Add(this.label5);
            this.configGroupBox.Controls.Add(this.btnStyleConfigure);
            this.configGroupBox.Controls.Add(this.label2);
            this.configGroupBox.Controls.Add(this.lblBannerheight);
            this.configGroupBox.Controls.Add(this.btnColorChooser);
            this.configGroupBox.Controls.Add(this.bannerHeightControl);
            this.configGroupBox.Controls.Add(this.label3);
            this.configGroupBox.Controls.Add(this.lblFontSize);
            this.configGroupBox.Location = new System.Drawing.Point(7, 124);
            this.configGroupBox.Name = "configGroupBox";
            this.configGroupBox.Size = new System.Drawing.Size(371, 182);
            this.configGroupBox.TabIndex = 15;
            this.configGroupBox.TabStop = false;
            this.configGroupBox.Text = "Configure Banner";
            this.configGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.configGroupBox_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 27);
            this.panel4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "UmairSyed613";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Tomato;
            this.lblStatus.Location = new System.Drawing.Point(143, 69);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 13);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "(Running)";
            this.lblStatus.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(8, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Note : Configuration settings cannot be applied when its in running status";
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Image = global::WinScreenKey.Properties.Resources.icons8_stop_squared_48;
            this.btnStop.Location = new System.Drawing.Point(324, 59);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 32);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 18;
            this.btnStop.TabStop = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Image = global::WinScreenKey.Properties.Resources.icons8_start_30__1_;
            this.btnStart.Location = new System.Drawing.Point(285, 60);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(30, 30);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 17;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStyleConfigure
            // 
            this.btnStyleConfigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyleConfigure.Image = global::WinScreenKey.Properties.Resources.icons8_clear_formatting_40;
            this.btnStyleConfigure.Location = new System.Drawing.Point(105, 72);
            this.btnStyleConfigure.Name = "btnStyleConfigure";
            this.btnStyleConfigure.Size = new System.Drawing.Size(30, 30);
            this.btnStyleConfigure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStyleConfigure.TabIndex = 21;
            this.btnStyleConfigure.TabStop = false;
            this.btnStyleConfigure.Click += new System.EventHandler(this.btnStyleConfigure_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinScreenKey.Properties.Resources.icons8_keyboard_64;
            this.pictureBox3.Location = new System.Drawing.Point(7, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::WinScreenKey.Properties.Resources.icons8_minimize_window_24;
            this.btnMinimize.Location = new System.Drawing.Point(324, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::WinScreenKey.Properties.Resources.icons8_close_window_24;
            this.btnClose.Location = new System.Drawing.Point(354, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Text Clear";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Banner Close";
            // 
            // txtTextClearTimeOut
            // 
            this.txtTextClearTimeOut.Location = new System.Drawing.Point(264, 77);
            this.txtTextClearTimeOut.Name = "txtTextClearTimeOut";
            this.txtTextClearTimeOut.Size = new System.Drawing.Size(77, 20);
            this.txtTextClearTimeOut.TabIndex = 24;
            this.txtTextClearTimeOut.Text = "2";
            this.txtTextClearTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTextClearTimeOut.TextChanged += new System.EventHandler(this.txtTextClearTimeOut_TextChanged);
            // 
            // txtBannerCloseTimeOut
            // 
            this.txtBannerCloseTimeOut.Location = new System.Drawing.Point(264, 115);
            this.txtBannerCloseTimeOut.Name = "txtBannerCloseTimeOut";
            this.txtBannerCloseTimeOut.Size = new System.Drawing.Size(77, 20);
            this.txtBannerCloseTimeOut.TabIndex = 25;
            this.txtBannerCloseTimeOut.Text = "7";
            this.txtBannerCloseTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBannerCloseTimeOut.TextChanged += new System.EventHandler(this.txtBannerCloseTimeOut_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "s";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "s";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(387, 348);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.configGroupBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "WinScreenKey";
            this.Load += new System.EventHandler(this.MainBanner_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerHeightControl)).EndInit();
            this.configGroupBox.ResumeLayout(false);
            this.configGroupBox.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStyleConfigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBannerheight;
        private System.Windows.Forms.TrackBar bannerHeightControl;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.FontDialog fontDlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel btnColorChooser;
        private System.Windows.Forms.GroupBox configGroupBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnStyleConfigure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBannerCloseTimeOut;
        private System.Windows.Forms.TextBox txtTextClearTimeOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

