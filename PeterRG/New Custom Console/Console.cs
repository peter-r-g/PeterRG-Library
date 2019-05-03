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
    class Console
    {
        public static Console instance { get; private set; }
        private static ConsoleUI consoleInterface;

        public Console()
        {
            if (instance != null)
                return;

            consoleInterface = new ConsoleUI();
            instance = this;
        }

    }
}
