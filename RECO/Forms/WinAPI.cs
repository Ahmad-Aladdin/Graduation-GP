using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RECO.Forms
{
    class WinAPI
    {
        public static int[] arr = { 0X1, 0X2, 0X4, 0X8, 0X10, 0X80000 };

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);

    }
}