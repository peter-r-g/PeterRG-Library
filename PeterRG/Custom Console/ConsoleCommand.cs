/*
 * 
 * Created by Peter Gorman
 * ConsoleCommand.cs
 * 
 */

using System;

namespace PeterRG.OldCustomConsole
{
    class ConsoleCommand
    {
        #region Variables
        public string command;
        public string description;
        public Func<string[], bool> function;
        #endregion

        #region Constructors
        /*
         * Name: ConsoleCommand
         * Purpose: Creates a new console command class.
         * Parameters: string, Func<string[], bool>
         * Returns: Nothing
         */
        public ConsoleCommand(string command, Func<string[], bool> function)
        {
            this.command = command;
            this.description = "No description.";
            this.function = function;
        }

        /*
         * Name: ConsoleCommand
         * Purpose: Creates a new console command class.
         * Parameters: string, string, Func<string[], bool>
         * Returns: Nothing
         */
        public ConsoleCommand(string command, string description, Func<string[], bool> function)
        {
            this.command = command;
            this.description = description;
            this.function = function;
        }
        #endregion
    }
}
