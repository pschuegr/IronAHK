using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Rusty.Common;
using Rusty.Windows;
using Rusty.Linux;

namespace Rusty
{
    partial class Core
    {
        static void InitVariables()
        {
            if (variables == null)
                variables = new Dictionary<string, object>();
        }


        static void InitKeyboardHook()
        {
            if (hotkeys == null)
                hotkeys = new Dictionary<string, Keyboard.HotkeyDefinition>();

            if (hotstrings == null)
                hotstrings = new Dictionary<string, Keyboard.HotstringDefinition>();

            if (keyboardHook != null)
                return;

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                keyboardHook = new Windows.KeyboardHook();
            else
                keyboardHook = new Linux.KeyboardHook();

            Keyboard.IAInputCommand.Instance.Hook = keyboardHook;
        }

        static void InitGui()
        {
            if (imageLists == null)
                imageLists = new Dictionary<long, ImageList>();
        }

        static Random RandomGenerator
        {
            get
            {
                if (randomGenerator == null)
                    randomGenerator = new Random();

                return randomGenerator;
            }
        }

        static void InitDialoges() {

            if(progressDialgos == null)
                progressDialgos = new Dictionary<int, ProgressDialog>();

            if(splashDialogs == null)
                splashDialogs = new Dictionary<int, SplashDialog>();
        }

    }
}
