using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
namespace _2048
{
    class GetCorrectScreenSize
    {
        [DllImport("User32.dll")]
        static extern IntPtr GetDC(IntPtr Hwnd);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateDC(
        string lpszDriver, // driver name
               string lpszDevice, // device name
               string lpszOutput, // not used; should be NULL
               Int64 lpInitData // optional printer data
               );

        [DllImport("gdi32.dll")]
        public static extern int GetDeviceCaps(
        IntPtr hdc, // handle to DC
               int nIndex // index of capability
               );

        [DllImport("user32.dll")]
        internal static extern bool SetProcessDPIAware();

        const int HORZRES = 8;
        const int VERTRES = 10;
        const int LOGPIXELSX = 88;
        const int LOGPIXELSY = 90;
        const int DESKTOPVERTRES = 117;
        const int DESKTOPHORZRES = 118;


        public static Size ScreenSize
        {
            get
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                Size size = new Size();
                size.Width = GetDeviceCaps(hdc, HORZRES);
                size.Height = GetDeviceCaps(hdc, VERTRES);
                ReleaseDC(IntPtr.Zero, hdc);
                size.Height *= (int)Scale;
                size.Width *= (int)Scale;
                return size;
            }
        }
        public static float Scale
        {
            get
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                int t = GetDeviceCaps(hdc, DESKTOPHORZRES);
                int d = GetDeviceCaps(hdc, HORZRES);
                float ScaleX = (float)GetDeviceCaps(hdc, DESKTOPHORZRES) / (float)GetDeviceCaps(hdc, HORZRES);
                ReleaseDC(IntPtr.Zero, hdc);
                return ScaleX;
            }
        }

    }
}
