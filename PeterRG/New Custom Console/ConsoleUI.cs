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
        private RichTextBox consoleLog;
        private TextBox consoleInput;
        private Button consoleSendInput;

        public delegate void OnConsoleLogCleared(string consoleTex);
        public event OnConsoleLogCleared onConsoleLogClearedEvent;


        public ConsoleUI()
        {
            consoleWindow = new Form();
            consoleLog = new RichTextBox();
            consoleInput = new TextBox();
            consoleSendInput = new Button();
            consoleWindow.SuspendLayout();

            consoleLog.Name = "consoleLog";
            consoleLog.ClientSize = new Size(786, 400);
            consoleLog.Left = 5;
            consoleLog.Top = 5;
            consoleLog.ReadOnly = true;
            //consoleLog.TextChanged += ConsoleLogTextChanged;

            consoleInput.Name = "consoleInput";
            consoleInput.ClientSize = new Size(710, 30);
            consoleInput.Top = 420;
            consoleInput.Left = 5;
            consoleInput.TabIndex = 0;
            consoleInput.KeyUp += ConsoleInputKeyUp;

            consoleSendInput.Name = "sendConsoleInput";
            consoleSendInput.ClientSize = new Size(70, 20);
            consoleSendInput.Top = 420;
            consoleSendInput.Left = 725;
            consoleSendInput.Text = "Send";
            consoleSendInput.TabIndex = 1;
            consoleSendInput.Click += SendConsoleInputClicked;

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

        /*public virtual void ConsoleLogTextChanged(object sender, EventArgs args)
        {
            if (autoScrollConsoleLog)
            {
                consoleLog.SelectionStart = consoleLog.Text.Length;
                consoleLog.ScrollToCaret();
            }

            if (consoleLog.Lines.Length > consoleLogMaxLines)
                consoleLog.Lines = (string[])consoleLog.Lines.Skip(1);
        }*/

        public virtual void ConsoleInputKeyUp(object sender, KeyEventArgs args)
        {
            /*if (args.KeyCode == Keys.Up)
            {
                if (inputIndex < inputHistory.Count)
                {
                    inputIndex++;
                    consoleInput.Text = inputHistory[inputIndex - 1];
                }
            }
            else if (args.KeyCode == Keys.Down)
            {
                if (inputIndex > 1)
                {
                    inputIndex--;
                    consoleInput.Text = inputHistory[inputIndex - 1];
                }
            }*/
        }

        public virtual void SendConsoleInputClicked(object sender, EventArgs args)
        {
            /*string input = GetConsoleInput();

            if (input == "")
                return;

            string[] words = input.Split(' ');
            bool hideInput = false;

            foreach (ConsoleCommand command in consoleCommands)
            {
                if (command.command == words[0])
                {
                    words.Skip(1);
                    hideInput = command.function(words);
                    consoleCommandExecutedEvent?.Invoke(command);
                    break;
                }
            }

            if (!hideInput)
                AddToConsole("> " + input);

            inputHistory.Add(input);
            ClearInput();*/
        }

        public void AddToConsoleLog(string text, bool newLine)
        {
            if (newLine)
                consoleLog.AppendText(text + Environment.NewLine);
            else
                consoleLog.AppendText(text);
        }

        public string[] GetConsoleLog()
        {
            return consoleLog.Lines;
        }

        public void WipeConsoleLog()
        {
            consoleLog.Lines = new string[0];
        }
    }
}
