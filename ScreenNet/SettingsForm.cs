using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ScreenNet
{
    partial class SettingsForm : Form
    {
        internal SettingsForm()
        {
            Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();

            checkBoxShowInTray.Checked = Settings.Default.ShowInTray;
            checkBoxAutoRun.Checked = Settings.Default.AutoRun;
            checkBoxAutoLoad.Checked = Settings.Default.AutoLoad;
            boxSaveFolder.Text = Settings.Default.SaveFolder;
            checkBoxAutoSave.Checked = Settings.Default.AutoSave;
            textBoxID.Text = Settings.Default.ClientID;
        }
        protected override void OnShown(EventArgs e)
        {
            if (Settings.Default.FirstRun)
            {
                SetValue("FirstRun", false);
                MessageBox.Show($"Установите необходимые параметры.{Environment.NewLine}Параметр Client ID необходим для загрузки изображения на Imgur.", "Первый запуск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        internal static void SetValue(string name, object value)
        {
            Settings.Default[name] = value;
            Settings.Default.Save();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите установить настройки по умолчанию (будет выполнен перезапуск приложения)?", "Сброс настроек", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            Settings.Default.Reset();
            try { Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true).DeleteValue("ScreenNet"); } catch { }
            Application.Restart();
        }

        private void checkBoxShowInTray_CheckedChanged(object sender, EventArgs e)
        {
            SetValue("ShowInTray", checkBoxShowInTray.Checked);
        }
        private void checkBoxAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (checkBoxAutoRun.Checked) rk.SetValue("ScreenNet", Application.ExecutablePath);
                else rk.DeleteValue("ScreenNet");
            }
            catch { MessageBox.Show("Возникли некоторые проблемы с добавлением приложения в автозапуск.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            SetValue("AutoRun", checkBoxAutoRun.Checked);
        }
        private void checkBoxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            SetValue("AutoLoad", checkBoxAutoLoad.Checked);
        }
        private void checkBoxAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            panelSave.Visible = checkBoxAutoSave.Checked;
            SetValue("AutoSave", checkBoxAutoSave.Checked);
            if (checkBoxAutoSave.Checked && boxSaveFolder.Text == String.Empty)
                boxSaveFolder_Click(boxSaveFolder, EventArgs.Empty);
        }
        private void boxSaveFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel && boxSaveFolder.Text == String.Empty)
            {
                checkBoxAutoSave.Checked = false;
                return;
            }
            if (folderBrowserDialog.SelectedPath != String.Empty)
            {
                boxSaveFolder.Text = folderBrowserDialog.SelectedPath;
                SetValue("SaveFolder", folderBrowserDialog.SelectedPath);
            }
        }
        private void boxSaveFolder_MouseHover(object sender, EventArgs e)
        {
            folderToolTip.SetToolTip(boxSaveFolder, boxSaveFolder.Text);
        }
        private void textBoxID_Validated(object sender, EventArgs e)
        {
            textBoxID.Text = textBoxID.Text.Replace(" ", String.Empty);
            SetValue("ClientID", textBoxID.Text);
        }
    }
}