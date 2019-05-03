/*
 * 
 * Created by Peter Gorman
 * Console.cs
 * 
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace PeterRG.CustomConsole
{
    class ConsoleUI
    {
        public Form consoleWindow;
        public RichTextBox consoleLog;
        public TextBox consoleInput;
        public Button consoleSendInput;

        public ConsoleUI()
        {
            // Create the form objects
            consoleWindow = new Form();
            consoleLog = new RichTextBox();
            consoleInput = new TextBox();
            consoleSendInput = new Button();
            consoleWindow.SuspendLayout();

            // Setup console log rich text box
            consoleLog.Name = "consoleLog";
            consoleLog.ClientSize = new Size(786, 400);
            consoleLog.Left = 5;
            consoleLog.Top = 5;
            consoleLog.ReadOnly = true;
            //consoleLog.TextChanged += ConsoleLogTextChanged;

            // Setup the console input text box
            consoleInput.Name = "consoleInput";
            consoleInput.ClientSize = new Size(710, 30);
            consoleInput.Top = 420;
            consoleInput.Left = 5;
            consoleInput.TabIndex = 0;
            //consoleInput.KeyUp += ConsoleInputKeyUp;

            // Setup the console send input button
            consoleSendInput.Name = "sendConsoleInput";
            consoleSendInput.ClientSize = new Size(70, 20);
            consoleSendInput.Top = 420;
            consoleSendInput.Left = 725;
            consoleSendInput.Text = "Send";
            consoleSendInput.TabIndex = 1;
            //consoleSendInput.Click += SendConsoleInputClicked;

            // Setup the console window
            consoleWindow.Name = "consoleWindow";
            consoleWindow.ClientSize = new Size(800, 450);
            consoleWindow.Controls.Add(consoleLog);
            consoleWindow.Controls.Add(consoleInput);
            consoleWindow.Controls.Add(consoleSendInput);
            consoleWindow.MaximizeBox = false;
            consoleWindow.Text = "Console";
            //consoleWindow.FormClosed += ConsoleWindowClosed;
            consoleWindow.AcceptButton = consoleSendInput;
            consoleWindow.ResumeLayout(false);
            consoleWindow.PerformLayout();
            consoleWindow.Show();
            consoleInput.Focus();
        }
    }
}
