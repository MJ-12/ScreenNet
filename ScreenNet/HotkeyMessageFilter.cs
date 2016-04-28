using System.Windows.Forms;

namespace ScreenNet
{
    class HotkeyMessageFilter : IMessageFilter
    {
        const int WM_HOTKEY = 0x312;
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                AppContext.StartCreating();
                return true;
            }
            return false;
        }
    }
}
