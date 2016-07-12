namespace PoisonScanner
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scanListview = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dropPanel = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showimageButton = new DevComponents.DotNetBar.ButtonX();
            this.detectionCount = new System.Windows.Forms.Label();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.UrlLink = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imageResultBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageResultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scanListview
            // 
            this.scanListview.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.scanListview.Border.Class = "ListViewBorder";
            this.scanListview.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.scanListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.scanListview.DisabledBackColor = System.Drawing.Color.Empty;
            this.scanListview.ForeColor = System.Drawing.Color.Black;
            this.scanListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.scanListview.Location = new System.Drawing.Point(419, 12);
            this.scanListview.Name = "scanListview";
            this.scanListview.Size = new System.Drawing.Size(307, 473);
            this.scanListview.TabIndex = 0;
            this.scanListview.UseCompatibleStateImageBehavior = false;
            this.scanListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AV";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Result";
            this.columnHeader2.Width = 170;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(117)))), ((int)(((byte)(104))))));
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.dropPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dropPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.dropPanel.Location = new System.Drawing.Point(12, 12);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(401, 311);
            this.dropPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.dropPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dropPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.dropPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.dropPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.dropPanel.Style.GradientAngle = 90;
            this.dropPanel.TabIndex = 1;
            this.dropPanel.Text = "Drop your file here, or click to select it manually!";
            this.dropPanel.Click += new System.EventHandler(this.dropPanel_Click);
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Detections:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "URL:";
            // 
            // showimageButton
            // 
            this.showimageButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.showimageButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.showimageButton.Enabled = false;
            this.showimageButton.Location = new System.Drawing.Point(12, 456);
            this.showimageButton.Name = "showimageButton";
            this.showimageButton.Size = new System.Drawing.Size(401, 29);
            this.showimageButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.showimageButton.TabIndex = 9;
            this.showimageButton.Text = "Show Image Result";
            this.showimageButton.Click += new System.EventHandler(this.showimageButton_Click);
            // 
            // detectionCount
            // 
            this.detectionCount.AutoSize = true;
            this.detectionCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.detectionCount.ForeColor = System.Drawing.Color.Black;
            this.detectionCount.Location = new System.Drawing.Point(83, 379);
            this.detectionCount.Name = "detectionCount";
            this.detectionCount.Size = new System.Drawing.Size(0, 13);
            this.detectionCount.TabIndex = 10;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filenameLabel.ForeColor = System.Drawing.Color.Black;
            this.filenameLabel.Location = new System.Drawing.Point(78, 342);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(0, 13);
            this.filenameLabel.TabIndex = 12;
            // 
            // UrlLink
            // 
            this.UrlLink.AutoSize = true;
            this.UrlLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UrlLink.ForeColor = System.Drawing.Color.Black;
            this.UrlLink.Location = new System.Drawing.Point(48, 416);
            this.UrlLink.Name = "UrlLink";
            this.UrlLink.Size = new System.Drawing.Size(0, 13);
            this.UrlLink.TabIndex = 17;
            this.toolTip.SetToolTip(this.UrlLink, "Click here to go to the scan results webpage!");
            this.UrlLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UrlLink_LinkClicked);
            // 
            // imageResultBox
            // 
            this.imageResultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imageResultBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageResultBox.ForeColor = System.Drawing.Color.Black;
            this.imageResultBox.Location = new System.Drawing.Point(388, 330);
            this.imageResultBox.Name = "imageResultBox";
            this.imageResultBox.Size = new System.Drawing.Size(25, 25);
            this.imageResultBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageResultBox.TabIndex = 18;
            this.imageResultBox.TabStop = false;
            this.toolTip.SetToolTip(this.imageResultBox, "Click here to go to image\'s webpage!");
            this.imageResultBox.Visible = false;
            this.imageResultBox.Click += new System.EventHandler(this.imageResultBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 497);
            this.Controls.Add(this.imageResultBox);
            this.Controls.Add(this.dropPanel);
            this.Controls.Add(this.UrlLink);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.detectionCount);
            this.Controls.Add(this.showimageButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scanListview);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButtonText = "& ABOUT ";
            this.HelpButtonVisible = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SettingsButtonText = "& SETTINGS";
            this.SettingsButtonVisible = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poison Scanner Desktop";
            this.SettingsButtonClick += new System.EventHandler(this.MainForm_SettingsButtonClick);
            this.HelpButtonClick += new System.EventHandler(this.MainForm_HelpButtonClick);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageResultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx scanListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.PanelEx dropPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonX showimageButton;
        private System.Windows.Forms.Label detectionCount;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.LinkLabel UrlLink;
        private System.Windows.Forms.PictureBox imageResultBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}