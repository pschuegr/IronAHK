using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Keyboardist
{
    partial class Program
    {
        const bool debug =
#if DEBUG
 true
#else
 false
#endif
;

        [SuppressUnmanagedCodeSecurityAttribute]
        internal static class SafeNativeMethods
        {
            [DllImport("kernel32.dll")]
            internal static extern bool AllocConsole();
        }
    }
}
