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
            this.lblKeys = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKeys
            // 
            this.lblKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKeys.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeys.Location = new System.Drawing.Point(0, 0);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(704, 108);
            this.lblKeys.TabIndex = 0;
            this.lblKeys.Text = "label1";
            this.lblKeys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 108);
            this.Controls.Add(this.lblKeys);
            this.Name = "MainWindow";
            this.Text = "WinScreenKey";
            this.Load += new System.EventHandler(this.MainBanner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKeys;
    }
}

