/*
 * 
 * Created by Peter Gorman
 * ConsoleUtil.cs
 * 
 */

using System;

namespace PeterRG.ConsoleUtilities
{
    class ConsoleUtil
    {
        #region Variables
        // Flag for if you want exceptions to be outputted to the console
        public static bool DEBUG = false;

        // The default strings to test against in GetBoolFromConsole()
        public static string DEFAULT_TRUE = "T";
        public static string DEFAULT_FALSE = "F";
        #endregion

        #region PauseConsole
        /*
         * Name: PauseConsole
         * Purpose: Pauses the console C style.
         * Parameters: Nothing
         * Returns: Nothing
         */
        public static void PauseConsole()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /*
         * Name: PauseConsole
         * Purpose: Pauses the console C style but with a custom message provided.
         * Parameters: string
         * Returns: Nothing
         */
        public static void PauseConsole(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
        #endregion

        #region GetIntFromConsole
        /*
         * Name: GetIntFromConsole
         * Purpose: Gets a string from the console and attempts to convert it to an integer.
         *          If it fails then it will return null.
         * Parameters: Nothing
         * Returns: object (int) or null if failed
         */
        public static object GetIntFromConsole()
        {
            try
            {
                string input = Console.ReadLine();
                return int.Parse(input);
            }
            catch (Exception e)
            {
                if (DEBUG)
                    Console.WriteLine(e.ToString());
                return null;
            }
        }

        /*
         * Name: GetIntFromConsole
         * Purpose: Gets a string from the console and attempts to convert it to an integer. If it fails and persist is true, then it will loop back around and try again.
         *          Otherwise see GetIntFromConsole()
         * Parameters: bool
         * Returns: object (double)
         */
        public static object GetIntFromConsole(bool persist)
        {
            if (persist)
            {
                while (true)
                {
                    object answer = GetIntFromConsole();

                    if (answer != null)
                        return answer;
                }
            }
            else
                return GetIntFromConsole();
        }
        #endregion

        #region GetFloatFromConsole
        /*
         * Name: GetFloatFromConsole
         * Purpose: Gets a string from the console and attempts to convert it to a float.
         *          If it fails then it will return null.
         * Parameters: Nothing
         * Returns: object (float) or null if failed
         */
        public static object GetFloatFromConsole()
        {
            try
            {
                string input = Console.ReadLine();
                return float.Parse(input);
            }
            catch (Exception e)
            {
                if (DEBUG)
                    Console.WriteLine(e.ToString());
                return null;
            }
        }

        /*
         * Name: GetFloatFromConsole
         * Purpose: Gets a string from the console and attempts to convert it to a float. If it fails and persist is true, then it will loop back around and try again.
         *          Otherwise see GetFloatFromConsole()
         * Parameters: bool
         * Returns: object (double)
         */
        public static object GetFloatFromConsole(bool persist)
        {
            if (persist)
            {
                while (true)
                {
                    object answer = GetFloatFromConsole();

                    if (answer != null)
                        return answer;
                }
            }
            else
                return GetFloatFromConsole();
        }
        #endregion

        #region GetLongFromConsole
        /*
         * Name: GetLongFromConsole
         * Purpose: Gets a string from the console and attempts to convert it to a long.
         *          If it fails then it will return null.
         * Parameters: Nothing
         * Returns: object (long) or null if failed
         */
        public static object GetLongFromConsole()
        {
            try
            {
                string input = Console.ReadLine();
                return long.Parse(input);
            }
            catch (Exception e)
            {
                if (DEBUG)
                    Console.WriteLine(e.ToString());
                return null;
            }
        }

        /*
         * Name: GetLongFromConsole
         * Purpose: Gets a string from the console and attempts to convert it to a long. If it fails and persist is true, then it will loop back around and try again.
         *          Otherwise see GetLongFromConsole()
         * Parameters: bool
         * Returns: object (double)
         */
        public static object GetLongFromConsole(bool persist)
        {
            if (persist)
            {
                while (true)
                {
                    object answer = GetLongFromConsole();

                    if (answer != null)
                        return answer;
                }
            }
            else
                return GetLongFromConsole();
        }
        #endregion

        #region GetDoubleFromConsole
        /*
         * Name: GetDoubleFromConsole
         * Purpose: Gets a string from the console and attempts to convert it to a double.
         *          If it fails then it will return null.
         * Parameters: Nothing
         * Returns: object (double) or null if failed
         */
        public static object GetDoubleFromConsole()
        {
            try
            {
                string input = Console.ReadLine();
                return double.Parse(input);
            }
            catch (Exception e)
            {
                if (DEBUG)
                    Console.WriteLine(e.ToString());
                return null;
            }
        }

        /*
         * Name: GetDoubleFromConsole
         * Purpose: Gets a string from the console and attempts to convert it to a double. If it fails and persist is true, then it will loop back around and try again.
         *          Otherwise see GetDoubleFromConsole()
         * Parameters: bool
         * Returns: object (double)
         */
        public static object GetDoubleFromConsole(bool persist)
        {
            if (persist)
            {
                while (true)
                {
                    object answer = GetDoubleFromConsole();

                    if (answer != null)
                        return answer;
                }
            }
            else
                return GetDoubleFromConsole();
        }
        #endregion

        #region GetBoolFromConsole
        /*
         * Name: GetBoolFromConsole
         * Purpose: Gets a string from the console and tests to see if it is "Y". If so, return true, if it is "N" then return false. 
         *          Otherwise returns null since it failed.
         * Parameters: Nothing
         * Returns: object (bool) or null if the user's response is not valid
         */
        public static object GetBoolFromConsole()
        {
            string input = Console.ReadLine();
            if (input.ToUpper() == DEFAULT_TRUE)
                return true;
            else if (input.ToUpper() == DEFAULT_FALSE)
                return false;
            else
                return null;
        }

        /*
         * Name: GetBoolFromConsole
         * Purpose: Gets a string from the console and tests to see if it is equal to trueText. If so, return true, if it is equal to falseText then return false. 
         *          Otherwise returns null since it failed.
         * Parameters: string, string
         * Returns: object (bool) or null if the user's response is not valid
         */
        public static object GetBoolFromConsole(string trueText, string falseText)
        {
            string input = Console.ReadLine();
            if (input == trueText)
                return true;
            else if (input == falseText)
                return false;
            else
                return null;
        }

        /*
         * Name: GetBoolFromConsole
         * Purpose: Gets a string from the console and tests to see if it is equal to trueText. If so, return true, otherwise return false.
         * Parameters: string, bool
         * Returns: object (bool)
         */
        public static object GetBoolFromConsole(string trueText, bool failedIsFalse)
        {
            string input = Console.ReadLine();
            if (input == trueText)
                return true;
            else
                return false;
        }

        /*
         * Name: GetBoolFromConsole
         * Purpose: Gets a string from the console and tests to see if it is "Y". If so, return true, if it is "N" then return false. 
         *          Otherwise loop back around and try again if persist is true. If persist is false then see GetBoolFromConsole()
         * Parameters: bool
         * Returns: object (bool)
         */
        public static object GetBoolFromConsole(bool persist)
        {
            if (persist)
            {
                while (true)
                {
                    object answer = GetBoolFromConsole();

                    if (answer != null)
                        return answer;
                }
            }
            else
                return GetBoolFromConsole();
        }

        /*
         * Name: GetBoolFromConsole
         * Purpose: Gets a string from the console and tests to see if it is equal to trueText. If so, return true, if it is equal to falseText then return false. 
         *          Otherwise loop back around and try again if persist is true. If persist is false then see GetBoolFromConsole(string, string)
         * Parameters: string, string, bool
         * Returns: object (bool)
         */
        public static object GetBoolFromConsole(string trueText, string falseText, bool persist)
        {
            if (persist)
            {
                while (true)
                {
                    object answer = GetBoolFromConsole(trueText, falseText);

                    if (answer != null)
                        return answer;
                }
            }
            else
                return GetBoolFromConsole(trueText, falseText);
        }
        #endregion
    }
}
