using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMR7_Patcher
{
    

    enum WindowsMessage
    {
        WM_SETTEXT = 0x000C,
        WM_GETTEXT = 0x000D
    }

    public class WindowsClass
    {
        public static readonly string hWnd = " ";

        public static string GetWindowCaption(IntPtr hwnd)
        {
            StringBuilder sb = new StringBuilder(256);
            pInvokes.GetWindowText(hwnd, sb, 256);
            return sb.ToString();
        }
    }
}
