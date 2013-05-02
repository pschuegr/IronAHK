using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IronAHK.Scripting;

[assembly: CLSCompliant(true)]
[assembly: InternalsVisibleTo("Setup, PublicKey=00240000048000009400000006020000002400005253413100040000010001009734282d68c536699358b36ad5636aa2d7fbd95ead0f6dc6c0708f19d400740e3aa4a0b5e6e779e5196bbefa6f12f19240a0f1a4daa3a4c8a59bf0067730915f9fcf4b3ee3844b290d39be63eb444f030ecd34570b3d784f307f10efc680ec37701e7f0008b0a8de2c6249c4896bf0cf1aa3cfadd434c40dcde17a25874cebcc")]

namespace Keyboardist
{
    static partial class Program
    {
        const int ExitSuccess = 0;
        static bool gui;

        [STAThread]
        static int Main(string[] args)
        {

            return 0;
        }
            
        static void Message(string text)
        {
            bool error = false;
            MessageBox.Show(text, typeof(Program).Namespace, MessageBoxButtons.OK, error ? MessageBoxIcon.Exclamation : MessageBoxIcon.Information);

            var stdout = error ? Console.Error : Console.Out;
            stdout.WriteLine(text);
        }

        internal static Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }
    }
}
