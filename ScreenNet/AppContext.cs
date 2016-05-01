using System;
using System.Windows.Forms;
using System.Drawing;

namespace ScreenNet
{
    class AppContext : ApplicationContext
    {
        ContextMenuStrip ContMenu;
        NotifyIcon NotIcon;
        static public MainForm main;
        static internal bool IsCreating;
   
        internal AppContext()
        {
            CreateContextMenuStrip();
            CreateNotifyIcon();
        }
        private void CreateContextMenuStrip()
        {
            ContMenu = new ContextMenuStrip();
            ToolStripItem OpenSettingsMenuItem = ContMenu.Items.Add("Настройки");
            OpenSettingsMenuItem.Click += (object sender, EventArgs e) => new SettingsForm().Show();
            ToolStripItem ExitMenuItem = ContMenu.Items.Add("Выход");
            ExitMenuItem.Click += (object sender, EventArgs e) => ExitThread();
        }
        private void CreateNotifyIcon()
        {
            NotIcon = new NotifyIcon();
            NotIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            NotIcon.Text = "Нажмите, чтобы создать скриншот";
            NotIcon.Visible = Settings.Default.ShowInTray;
            NotIcon.Click += (object sender, EventArgs e) => { if (((MouseEventArgs)e).Button == MouseButtons.Left) StartCreating(); };
            if (ContMenu != null)
                NotIcon.ContextMenuStrip = ContMenu;
        }

        static internal void StartCreating()
        {
            if (IsCreating)
                return;
            IsCreating = true;
            if (main != null)
            {
                main.Opacity = 0D;
                main.backgroundUpload.CancelAsync();
                main.Dispose();
            }
            new CreatingForm().Show();
        }
        static internal void FinishCreating(Image image)
        {
            IsCreating = false;
            if (image == null)
                return;
            main = new MainForm { img = image };
            main.Show();  
        }
    }
}
