using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Rusty.Linux.X11
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct XModifierKeymap
    {
        public int max_keypermod;
        public IntPtr modifiermap;
    }
}
