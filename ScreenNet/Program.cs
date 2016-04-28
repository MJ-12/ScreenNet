using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ScreenNet
{
    static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        const int CTRL = 0x0002;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Settings.Default.FirstRun)
                Application.Run(new SettingsForm());
            AppContext context = new AppContext();
            HotkeyMessageFilter MessageFilter = new HotkeyMessageFilter();
            Application.AddMessageFilter(MessageFilter);
            RegisterHotKey(new IntPtr(0), context.GetHashCode(), CTRL, (int)Keys.F12); //CTRL+F12 for creating
            Application.Run(context);
            UnregisterHotKey(new IntPtr(0), context.GetHashCode());
        }
    }
}
