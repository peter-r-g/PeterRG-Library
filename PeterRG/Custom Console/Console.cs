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
    class Console
    {
        // Use this so we don't have multiple consoles.
        public static Console instance { get; private set; }

        #region Variables
        // Form objects
        public Form consoleWindow { get; private set; }
        private RichTextBox consoleLog;
        private TextBox consoleInput;
        private Button sendConsoleInput;

        // Configurable variables
        public int consoleLogMaxLines { get; private set; } = 50;
        public int inputHistoryLength { get; private set; } = 100;

        public bool exitAppOnConsoleClosed { get; private set; } = false;
        public bool autoScrollConsoleLog { get; private set; } = false;

        // Input history
        private int inputIndex = 0;
        private List<string> inputHistory = new List<string>();

        // Console commands
        private List<ConsoleCommand> consoleCommands = new List<ConsoleCommand>();
        #endregion

        #region Events
        // Event for when the consoles log is cleared
        public delegate void ConsoleCleared(string consoleText);
        public event ConsoleCleared consoleClearedEvent;

        // Event for when text is added to the console log
        public delegate void TextAddedToConsole(string text);
        public event TextAddedToConsole textAddedToConsoleEvent;

        // Event for when a console command is executed
        public delegate void ConsoleCommandExecuted(ConsoleCommand command);
        public event ConsoleCommandExecuted consoleCommandExecutedEvent;
        #endregion

        #region Constructors
        /*
         * Name: Console
         * Purpose: Creates a new console window. If one already exists then cancel.
         * Parameters: Nothing
         * Returns: Nothing
         */
        public Console()
        {
            // Check if a console already exists
            if (instance != null)
                return;

            // Create the form objects
            consoleWindow = new Form();
            consoleLog = new RichTextBox();
            consoleInput = new TextBox();
            sendConsoleInput = new Button();
            consoleWindow.SuspendLayout();

            // Setup console log rich text box
            consoleLog.Name = "consoleLog";
            consoleLog.ClientSize = new Size(786, 400);
            consoleLog.Left = 5;
            consoleLog.Top = 5;
            consoleLog.ReadOnly = true;
            consoleLog.TextChanged += ConsoleLogTextChanged;

            // Setup the console input text box
            consoleInput.Name = "consoleInput";
            consoleInput.ClientSize = new Size(710, 30);
            consoleInput.Top = 420;
            consoleInput.Left = 5;
            consoleInput.TabIndex = 0;
            consoleInput.KeyUp += ConsoleInputKeyUp;

            // Setup the console send input button
            sendConsoleInput.Name = "sendConsoleInput";
            sendConsoleInput.ClientSize = new Size(70, 20);
            sendConsoleInput.Top = 420;
            sendConsoleInput.Left = 725;
            sendConsoleInput.Text = "Send";
            sendConsoleInput.TabIndex = 1;
            sendConsoleInput.Click += SendConsoleInputClicked;

            // Setup the console window
            consoleWindow.Name = "consoleWindow";
            consoleWindow.ClientSize = new Size(800, 450);
            consoleWindow.Controls.Add(consoleLog);
            consoleWindow.Controls.Add(consoleInput);
            consoleWindow.Controls.Add(sendConsoleInput);
            consoleWindow.MaximizeBox = false;
            consoleWindow.Text = "Console";
            consoleWindow.FormClosed += ConsoleWindowClosed;
            consoleWindow.AcceptButton = sendConsoleInput;
            consoleWindow.ResumeLayout(false);
            consoleWindow.PerformLayout();
            consoleWindow.Show();
            consoleInput.Focus();

            // Load default console commands
            LoadConsoleCommands();

            // Set the instance so we can't create anymore consoles
            instance = this;
        }
        #endregion

        #region Base console command functions
        /*
         * Name: HelpFunction
         * Purpose: Displays all console commands available.
         * Parameters: string[]
         * Returns: bool
         */
        private bool HelpFunction(string[] args)
        {
            AddToConsole("These are the following commands currently registered:");
            foreach (ConsoleCommand command in consoleCommands)
            {
                AddToConsole("Command: " + command.command);
                AddToConsole("Description: " + command.description + Environment.NewLine);
            }

            return true;
        }

        /*
         * Name: ClearFunction
         * Purpose: Clears the console log.
         * Parameters: string[]
         * Returns: bool
         */
        private bool ClearFunction(string[] args)
        {
            ClearConsole();

            return true;
        }

        /*
         * Name: ExitFunction
         * Purpose: Exits the application.
         * Parameters: string[]
         * Returns: bool
         */
        private bool ExitFunction(string[] args)
        {
            Application.Exit();

            return true;
        }
        #endregion

        #region Form events
        /*
         * Name: ConsoleWindowClosed
         * Purpose: Event for when the console window closes. If exitAppOnConsoleClosed is true then the application will exit.
         * Parameters: object, EventArgs
         * Returns: Nothing
         */
        private void ConsoleWindowClosed(object sender, EventArgs args)
        {
            if (exitAppOnConsoleClosed)
                Application.Exit();
        }

        /*
         * Name: ConsoleLogTextChanged
         * Purpose: Event for when the text changes in the console log. If autoScrollConsoleLog is true then it will scroll back to the bottom.
         *          If the amount of lines in the console log exceeds the limit then the oldest log will be removed.
         * Parameters: object, EventArgs
         * Returns: Nothing
         */
        private void ConsoleLogTextChanged(object sender, EventArgs args)
        {
            if (autoScrollConsoleLog)
            {
                consoleLog.SelectionStart = consoleLog.Text.Length;
                consoleLog.ScrollToCaret();
            }

            if (consoleLog.Lines.Length > consoleLogMaxLines)
                consoleLog.Lines = (string[])consoleLog.Lines.Skip(1);
        }

        /*
         * Name: ConsoleInputKeyUp
         * Purpose: Event for when a key is released in the console input. If they key is the up or down arrow then we shift through the input history.
         * Parameters: object, EventArgs
         * Returns: Nothing
         */
        private void ConsoleInputKeyUp(object sender, KeyEventArgs args)
        {
            if (args.KeyCode == Keys.Up)
            {
                if (inputIndex < inputHistory.Count)
                {
                    inputIndex++;
                    consoleInput.Text = inputHistory[inputIndex-1];
                }
            }
            else if (args.KeyCode == Keys.Down)
            {
                if (inputIndex > 1)
                {
                    inputIndex--;
                    consoleInput.Text = inputHistory[inputIndex-1];
                }
            }
        }

        /*
         * Name: SendConsoleInputClicked
         * Purpose: Event for when the send button is clicked. This will take the console input and check if the first word is a command. If it is then the command will be executed.
         *          Afterwards the text in the console input will be added to the log.
         * Parameters: object, EventArgs
         * Returns: Nothing
         */
        private void SendConsoleInputClicked(object sender, EventArgs args)
        {
            string input = GetConsoleInput();

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
            ClearInput();
        }
        #endregion

        #region AddToConsole Functions
        /*
         * Name: AddTextToConsole
         * Purpose: Adds text to the console log. If newLine is true then a new line will be inserted afterwards.
         * Parameters: string, bool
         * Returns: Nothing
         */
        private void AddTextToConsole(string text, bool newLine)
        {
            if (newLine)
                consoleLog.AppendText(text + Environment.NewLine);
            else
                consoleLog.AppendText(text);
            textAddedToConsoleEvent?.Invoke(text);
        }

        /*
         * Name: AddToConsole
         * Purpose: Adds a list of items to the console.
         * Parameters: params object[]
         * Returns: Nothing
         */
        public void AddToConsole(params object[] list)
        {
            for (int i=0; i<list.Length; i++)
            {
                AddTextToConsole(list[i].ToString(), true);
            }
        }

        /*
         * Name: AddToConsole
         * Purpose: Adds a list of items to the console. If newLine is true then a new line will be inserted afterwards.
         * Parameters: bool, params object[]
         * Returns: Nothing
         */
        public void AddToConsole(bool newLine, params object[] list)
        {
            if (newLine)
                AddToConsole(list);
            else
            {
                for (int i=0; i<list.Length; i++)
                {
                    AddTextToConsole(list[i].ToString(), false);
                }
            }
        }

        /*
         * Name: Write
         * Purpose: The same as the default System.Console.Write
         * Parameters: text
         * Returns: Nothing
         */
        public void Write(string text)
        {
            AddTextToConsole(text, false);
        }

        /*
         * Name: WriteLine
         * Purpose: The same as the default System.Console.WriteLine
         * Parameters: string
         * Returns: Nothing
         */
        public void WriteLine(string text)
        {
            AddTextToConsole(text, true);
        }
        #endregion

        #region Misc Functions
        /*
         * Name: AddConsoleCommand
         * Purpose: Adds a new console command.
         * Parameters: ConsoleCommand
         * Returns: Nothing
         */
        public void AddConsoleCommand(ConsoleCommand command)
        {
            consoleCommands.Add(command);
        }

        /*
         * Name: AutoScrollConsole
         * Purpose: Sets whether the console should auto scroll or not.
         * Parameters: bool
         * Returns: Nothing
         */
        public void AutoScrollConsole(bool value)
        {
            autoScrollConsoleLog = value;
        }

        /*
         * Name: ClearConsole
         * Purpose: Clears the consoles log.
         * Parameters: Nothing
         * Returns: Nothing
         */
        public void ClearConsole()
        {
            consoleClearedEvent?.Invoke(consoleLog.Text);
            consoleLog.Clear();
        }

        /*
         * Name: ClearInput
         * Purpose: Clears the consoles input.
         * Parameters: Nothing
         * Returns: Nothing
         */
        public void ClearInput()
        {
            consoleInput.Clear();
        }

        /*
         * Name: ExitOnConsoleClosed
         * Purpose: Sets whether the application should exit when the console is closed.
         * Parameters: bool
         * Returns: Nothing
         */
        public void ExitOnConsoleClosed(bool value)
        {
            exitAppOnConsoleClosed = value;
        }

        /*
         * Name: MaxLines
         * Purpose: Sets the amount of lines the console log can hold.
         * Parameters: int
         * Returns: Nothing
         */
        public void MaxLines(int max)
        {
            consoleLogMaxLines = max;
        }

        /*
         * Name: LoadConsoleCommands
         * Purpose: Internal function for the consoles constructor. This adds the default console commands.
         * Parameters: Nothing
         * Returns: Nothing
         */
        private void LoadConsoleCommands()
        {
            AddConsoleCommand(new ConsoleCommand("help", "This shows all commands registered", HelpFunction));
            AddConsoleCommand(new ConsoleCommand("clear", "Clears the console", ClearFunction));
            AddConsoleCommand(new ConsoleCommand("exit", "Exits the application", ExitFunction));
        }

        /*
         * Name: Show
         * Purpose: Shows the console window.
         * Parameters: Nothing
         * Returns: Nothing
         */
        public void Show()
        {
            consoleWindow.Show();
        }

        /*
         * Name: Hide
         * Purpose: Hides the console window.
         * Parameters: Nothing
         * Returns: Nothing
         */
        public void Hide()
        {
            consoleWindow.Hide();
        }
        #endregion

        #region Getters
        /*
         * Name: GetConsoleLogText
         * Purpose: Returns the text in the console log.
         * Parameters: Nothing
         * Returns: string
         */
        public string GetConsoleLogText()
        {
            return consoleLog.Text;
        }

        /*
         * Name: GetConsoleInput
         * Purpose: Returns the text in the console input.
         * Parameters: Nothing
         * Returns: string
         */
        public string GetConsoleInput()
        {
            return consoleInput.Text;
        }

        /*
         * Name: GetConsoleCommands
         * Purpose: Returns the list of console commands registered.
         * Parameters: Nothing
         * Returns: ConsoleCommand list
         */
        public List<ConsoleCommand> GetConsoleCommands()
        {
            return consoleCommands;
        }
        #endregion
    }
}
