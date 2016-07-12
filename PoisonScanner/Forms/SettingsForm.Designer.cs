namespace PoisonScanner
{
    partial class Settings
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
            this.colorCombControl1 = new DevComponents.DotNetBar.ColorPickers.ColorCombControl();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // colorCombControl1
            // 
            this.colorCombControl1.Location = new System.Drawing.Point(12, 12);
            this.colorCombControl1.Name = "colorCombControl1";
            this.colorCombControl1.Size = new System.Drawing.Size(326, 167);
            this.colorCombControl1.TabIndex = 0;
            this.colorCombControl1.Text = "colorCombControl1";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX1.Location = new System.Drawing.Point(12, 256);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(326, 38);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "buttonX1";
            this.buttonX1.ThemeAware = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 306);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.colorCombControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ColorPickers.ColorCombControl colorCombControl1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}