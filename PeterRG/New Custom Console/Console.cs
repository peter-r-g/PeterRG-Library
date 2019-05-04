/*
 * 
 * Created by Peter Gorman
 * PeterRGConsole.cs
 * 
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using PeterRG.CustomConsole;

namespace PeterRG.PeterRGConsole
{
    class Console : ConsoleUI
    {
        public static Console instance { get; private set; }

        public Console() : base()
        {
            if (instance != null)
                return;

            instance = this;
        }

    }
}
