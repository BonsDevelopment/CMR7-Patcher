using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMR7_Patcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Process pName = Process.GetProcessesByName("CookieMuncherRevision7-")[0];

            IntPtr hWnd = pInvokes.FindWindowEx(pName.MainWindowHandle, IntPtr.Zero, "WindowsForms10.Window.8.app.0.141b42a_r9_ad1", null);

            foreach (var childHandle in ChildHandleEnum.GetChildWindows(hWnd))
            {
                if (WindowsClass.GetWindowCaption(childHandle).Length > 100)
                    pInvokes.SendMessage(childHandle, (int)WindowsMessage.WM_SETTEXT, 0, WindowsClass.hWnd);

            }
        }


    }
}
