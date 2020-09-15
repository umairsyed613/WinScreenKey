using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WinScreenKey.Helpers
{
    internal class MemoryHelper
    {
        [DllImport("kernel32")]
        static extern bool SetProcessWorkingSetSize(IntPtr handle, int minSize, int maxSize);

        internal static void MemoryCleanup()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
        }
    }
}
