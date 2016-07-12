using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Drawing;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace PoisonScanner
{
    public partial class MainForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string scanImageUrl;
        const string defaultdroptext = "Drop your file here, or click to select it manually!";

        #region"Events"

        private void MainForm_Load(object sender, EventArgs e)
        {
            imageResultBox.Location = new Point(419, 12);
            imageResultBox.Size = new Size(307, 473);
        }

        private void MainForm_HelpButtonClick(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is AboutForm)
                {
                    f.Focus();
                    return;
                }
            }
            new AboutForm().Show();
        }

        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length == 1)
            {
                foreach (string file in files)
                {
                    Scan(file);
                }
            }
            else
            {
                MessageBoxEx.Show(null, "You may only scan one file at a time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dropPanel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (openFileDialog.FileName != String.Empty)
                Scan(openFileDialog.FileName);
        }

        private void showimageButton_Click(object sender, EventArgs e)
        {
            switch(showimageButton.Text)
            {
                case "Show Image Result":
                    showimageButton.Text = "Show List Result";                   
                    imageResultBox.Visible = true;
                    scanListview.Visible = false;
                    break;

                case "Show List Result":
                    showimageButton.Text = "Show Image Result";
                    imageResultBox.Visible = false;
                    scanListview.Visible = true;
                    break;
            }
        }

        private void GetResults(object sender, UploadFileCompletedEventArgs e)
        {
            try
            {
                string @string = Encoding.UTF8.GetString(e.Result);
                AddtoLV(@string);
                addIMG(@string);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void UrlLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(UrlLink.Text);
        }

        private void imageResultBox_Click(object sender, EventArgs e)
        {
            try { Process.Start(scanImageUrl); } catch { };
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Environment.Exit(0);
        }
        #endregion

        #region"Functions"
        public async void Scan(string Filename)
        {
            bool flag = new FileInfo(Filename).Length >= 8388608L;
            if (flag)
            {
                MessageBoxEx.Show(null, "You can not scan a file larger than 8mb!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                dropPanel.Text = "Scanning file. . .";
                dropPanel.AllowDrop = false;
                dropPanel.Enabled = false;
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.UploadFileCompleted += new UploadFileCompletedEventHandler(this.GetResults);
                    await webClient.UploadFileTaskAsync(new Uri("https://www.pscan.xyz/api.php"), "POST", Filename);
                }
                catch (Exception ex)
                {
                    dropPanel.Enabled = true;
                    dropPanel.AllowDrop = true;
                    dropPanel.Text = "Drop your file here, or click to select it manually!";
                    MessageBoxEx.Show(ex.Message);
                }
            }
        }

        private void AddtoLV(string response)
        {
            scanListview.Items.Clear();
            dropPanel.Enabled = true;
            dropPanel.AllowDrop = true;
            dropPanel.Text = defaultdroptext;
            showimageButton.Enabled = true;

            try
            {
                string[] separator = new string[]
                {
                    "[NextAV]"
                };
                string[] array = response.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string[] separator2 = new string[]
                {
                    "[ResultDetails]"
                };
                string[] array2 = response.Split(separator2, StringSplitOptions.RemoveEmptyEntries);
                string[] separator3 = new string[]
                {
                    "[Details]"
                };
                string[] array3 = array2[1].Split(separator3, StringSplitOptions.RemoveEmptyEntries);
                filenameLabel.Text = array3[0];
                detectionCount.Text = array3[4];
                UrlLink.Text = array3[5];
                int num = 0;
                string[] array4 = array;
                for (int i = 0; i < array4.Length; i++)
                {
                    string text = array4[i];
                    bool flag = ++num == 36;
                    if (flag)
                    {
                        break;
                    }
                    string[] separator4 = new string[]
                    {
                        "[]Result[]"
                    };
                    string[] array5 = text.Split(separator4, StringSplitOptions.RemoveEmptyEntries);
                    ListViewItem listViewItem = new ListViewItem(array5[0]);
                    listViewItem.SubItems.Add(array5[1]);
                    bool flag2 = array5[1] == "OK";
                    if (flag2)
                    {
                        listViewItem.ForeColor = Color.ForestGreen;
                    }
                    else
                    {
                        listViewItem.ForeColor = Color.Red;
                    }
                    scanListview.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void addIMG(string response)
        {
            string[] separator = new string[]
            {
                "[ResultDetails]"
            };
            string[] array = response.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string[] separator2 = new string[]
            {
                "[Details]"
            };
            string[] array2 = array[1].Split(separator2, StringSplitOptions.RemoveEmptyEntries);
            scanImageUrl = array2[6];
            WebRequest webRequest = WebRequest.Create(array2[6]);
            imageResultBox.Image = Image.FromStream(webRequest.GetResponse().GetResponseStream());
        }
        #endregion

        private void MainForm_SettingsButtonClick(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Settings)
                {
                    f.Focus();
                    return;
                }
            }
            new Settings().Show();
        }
    }
}