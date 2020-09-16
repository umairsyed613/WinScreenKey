namespace WinScreenKey
{
    partial class Banner
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
            this.lblKeys.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeys.Location = new System.Drawing.Point(0, 0);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(370, 70);
            this.lblKeys.TabIndex = 1;
            this.lblKeys.Text = "KeyData";
            this.lblKeys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Banner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(370, 70);
            this.Controls.Add(this.lblKeys);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Banner";
            this.ShowInTaskbar = false;
            this.Text = "Banner";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Banner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKeys;
    }
}