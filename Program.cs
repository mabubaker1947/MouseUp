using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MouseUpConsoleApp
{
    class Program
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int STD_OUTPUT_HANDLE = -11;
        const int LEFT_DOWN = 0x00000002;
        const int LEFT_UP = 0x00000004;

        static void Main(string[] args)
        {
            while (true)
            {
                //mouse_event(LEFT_DOWN, 0, 0, 0, 0);
                mouse_event(LEFT_UP, 0, 0, 0, 0);
                Thread.Sleep(299790); // wait for just before 5 minutes count is completed to lock the PC
            }
        }
    }
}
