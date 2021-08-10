using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Picture_Toolbox.Properties;
using TinifyAPI;
using Exception = System.Exception;

namespace Picture_Toolbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) SelectedDir.Text = dialog.FileName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (resize.Checked)
            {
                s1.Enabled = true;
                s2.Enabled = true;
            }
            else
            {
                s1.Enabled = false;
                s2.Enabled = false;
            }
        }

        private async void ValidateAPI_Click(object sender, EventArgs e)
        {
            try
            {
                Tinify.Key = API.Text;
                await Tinify.Validate();
                API.Enabled = false;
                ValidateAPI.Click -= ValidateAPI_Click;
                ValidateAPI.Text = "VALID";
                ValidateAPI.ForeColor = Color.Green;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error");
            }
        }

        private void SStatus(int x) // 1 working 2 error else waiting
        {
            switch (x)
            {
                case 1:
                    Status.Text = "WORKING";
                    Status.ForeColor = Color.Green;
                    break;
                //case 2: // skipped since it seems silly to imlement this as it already shows a popup error
                //    Status.Text = "ERROR";
                //    Status.ForeColor = Color.Red;
                //    break;
                default:
                    Status.Text = "WAITING";
                    Status.ForeColor = Color.Black;
                    break;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (API.Enabled)
                MessageBox.Show("API KEY NOT SET!!!!!!", "Error");
            else if (SelectedDir.Text == "")
                MessageBox.Show("Select a directory", "Error");
            else
                try
                {
                    var supportedExtensions = "*.jpg,*.png";

                    var files = Directory.GetFiles(SelectedDir.Text, "*.*", SearchOption.TopDirectoryOnly)
                        .Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())).ToList();
                    progressBar1.Value = 0;
                    progressBar1.Maximum = files.Count();
                    SStatus(1);
                    if (resize.Checked)
                        foreach (var x in files)
                        {
                            await Tinify.FromFile(x).Resize(new
                            {
                                method = comboBox1.Text,
                                width = s1.Value,
                                height = s2.Value
                            }).ToFile(x);
                            progressBar1.Value++;
                        }
                    else
                        foreach (var x in files)
                        {
                            await Tinify.FromFile(x).ToFile(x);
                            progressBar1.Value++;
                        }

                    SStatus(0);
                    MessageBox.Show("Everything processed successfully", "Finish");
                }
                catch (Exception x)
                {
                    SStatus(0);
                    progressBar1.Value = 0;
                    MessageBox.Show(x.Message, "Error");
                }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (API.Enabled == false) Settings.Default.API = API.Text;
            Settings.Default.s1 = s1.Value;
            Settings.Default.s2 = s2.Value;
            Settings.Default.type = comboBox1.Text;
            Settings.Default.resize = resize.Checked;
            Settings.Default.Save();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            API.Text = Settings.Default.API;
            resize.Checked = Settings.Default.resize;
            s1.Value = Settings.Default.s1;
            s2.Value = Settings.Default.s2;
            comboBox1.Text = Settings.Default.type;
            if (API.Text != "") ValidateAPI_Click(null, null);
        }
    }
}