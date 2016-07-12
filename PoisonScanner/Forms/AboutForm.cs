using System;
using System.Diagnostics;

namespace PoisonScanner
{
    public partial class AboutForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logoPicture_Click(object sender, EventArgs e)
        {
            Process.Start("http://pscan.xyz/");
        }
    }
}