using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace ScreenNet
{
    partial class MainForm : Form
    {
        Image image;
        internal Image img { get { return image; } set { screenbox.Image = image = value; } }
        Uri url = new Uri(@"https://imgur.com");

        internal MainForm()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();
            
            buttonSettings.Text = "\uE713"; //Settings
            buttonSave.Text = "\uE74E"; //Save
            buttonCopy.Text = "\uE8C8"; //Copy
            buttonLoad.Text = "\uE898"; //Upload
            buttonUrl.Text = "\uE71B"; //Link 
        }
        protected override void OnLoad(EventArgs e)
        {
            buttonCopy.PerformClick();
            if (Settings.Default.AutoSave && Directory.Exists(Settings.Default.SaveFolder)) image.Save($"{Settings.Default.SaveFolder}\\screenshot_{DateTime.Now.ToString("ddMMyyyy-HHmmss")}.png");
            if (Settings.Default.AutoLoad) buttonLoad.PerformClick();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            buttonLoad.Enabled = false;
            progressUpload.Visible = true;
            backgroundUpload.RunWorkerAsync();
        }

        #region backgroundUpload
        private void backgroundUpload_DoWork(object sender, DoWorkEventArgs e)
        {
            Ping pingImgur = new Ping();
            backgroundUpload.ReportProgress(10);
            IPStatus st = IPStatus.Unknown;
            backgroundUpload.ReportProgress(13);
            try { st = pingImgur.Send("api.imgur.com", 1000).Status; } catch { }
            backgroundUpload.ReportProgress(15);
            if (st != IPStatus.Success)
            {
                e.Cancel = true;
                return;
            }
            backgroundUpload.ReportProgress(20);

            MemoryStream ms = new MemoryStream();
            backgroundUpload.ReportProgress(25);
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            backgroundUpload.ReportProgress(30);
            byte[] img = Encoding.ASCII.GetBytes(Convert.ToBase64String(ms.ToArray()));
            backgroundUpload.ReportProgress(40);
            if (backgroundUpload.CancellationPending)
                return;
            WebClient wc = new WebClient();
            backgroundUpload.ReportProgress(45);
            wc.Headers.Add($"Authorization: Client-ID {Settings.Default.ClientID}");
            backgroundUpload.ReportProgress(50);
            byte[] bytes;
            backgroundUpload.ReportProgress(55);
            if (backgroundUpload.CancellationPending)
                return;
            try { bytes = wc.UploadData("https://api.imgur.com/3/image", "POST", img); } catch { e.Cancel = true; return; }
            backgroundUpload.ReportProgress(75);
            string responceStr = Encoding.UTF8.GetString(bytes);
            backgroundUpload.ReportProgress(80);

            Match match = Regex.Match(responceStr, @"""?id""?:\s?""?(\w+)""?", RegexOptions.IgnoreCase);
            backgroundUpload.ReportProgress(90);
            if (match.Success)
            {
                url = new Uri($"https://i.imgur.com/{match.Groups[1].Value}.png");
                e.Result = true;
            }
            else
                e.Result = false;
            backgroundUpload.ReportProgress(100);
        }
        private void backgroundUpload_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressUpload.Value = e.ProgressPercentage;
        }
        private void backgroundUpload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressUpload.Visible = false;
            progressUpload.Value = 0;
            if (backgroundUpload.CancellationPending)
                return;
            if (e.Cancelled)
            {
                buttonLoad.Enabled = true;
                buttonLoad.Text = "\uE8EE"; //RepeatAll
                MessageBox.Show("Проверьте свое подключение к сети или секретный ключ.", "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((bool)e.Result)
            {
                buttonLoad.Text = "\uE8FB"; //Accept
                buttonUrl.Visible = true;
                buttonUrl.Cursor = Cursors.Default;
            }
            else
            {
                buttonLoad.Enabled = true;
                buttonLoad.Text = "Попробовать еще раз";
                MessageBox.Show("Что-то пошло не так", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveScreen.ShowDialog() != DialogResult.OK)
                return;
            image.Save(saveScreen.FileName);
        }
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(image);
        }
        private void url_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(url.AbsoluteUri);
        }
    }
}