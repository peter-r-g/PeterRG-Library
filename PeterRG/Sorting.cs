/*
 * 
 * Created by Peter Gorman
 * Sorting.cs
 * 
 */

using System.Collections.Generic;

namespace PeterRG.Sorting
{
    class Bubble
    {
        #region Sbyte
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: sbyte array
         * Returns: sbyte array
         */
        public static sbyte[] Sort(sbyte[] numbers)
        {
            sbyte[] sortedNumbers = numbers;

            for (uint i = 0; i < sortedNumbers.Length; i++)
            {
                for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        sbyte temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: sbyte array
         * Returns: sbyte array
         */
        public static sbyte[] Sort(sbyte[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                sbyte[] sortedNumbers = numbers;

                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            sbyte temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: byte list
         * Returns: byte list
         */
        public static List<sbyte> Sort(List<sbyte> numbers)
        {
            List<sbyte> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        sbyte temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: byte list
         * Returns: byte list
         */
        public static List<sbyte> Sort(List<sbyte> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<sbyte> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            sbyte temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion

        #region Byte
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: byte array
         * Returns: byte array
         */
        public static byte[] Sort(byte[] numbers)
        {
            byte[] sortedNumbers = numbers;

            for (uint i = 0; i < sortedNumbers.Length; i++)
            {
                for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        byte temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: byte array
         * Returns: byte array
         */
        public static byte[] Sort(byte[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                byte[] sortedNumbers = numbers;

                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            byte temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: byte list
         * Returns: byte list
         */
        public static List<byte> Sort(List<byte> numbers)
        {
            List<byte> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        byte temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: byte list
         * Returns: byte list
         */
        public static List<byte> Sort(List<byte> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<byte> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            byte temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion

        #region Short
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: short array
         * Returns: short array
         */
        public static short[] Sort(short[] numbers)
        {
            short[] sortedNumbers = numbers;

            for (uint i = 0; i < sortedNumbers.Length; i++)
            {
                for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        short temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: short array
         * Returns: short array
         */
        public static short[] Sort(short[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                short[] sortedNumbers = numbers;
                
                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            short temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: short list
         * Returns: short list
         */
        public static List<short> Sort(List<short> numbers)
        {
            List<short> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        short temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: short list
         * Returns: short list
         */
        public static List<short> Sort(List<short> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<short> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            short temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion

        #region Ushort
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: ushort array
         * Returns: ushort array
         */
        public static ushort[] Sort(ushort[] numbers)
        {
            ushort[] sortedNumbers = numbers;

            for (uint i = 0; i < sortedNumbers.Length; i++)
            {
                for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        ushort temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: ushort array
         * Returns: ushort array
         */
        public static ushort[] Sort(ushort[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                ushort[] sortedNumbers = numbers;

                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            ushort temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: ushort list
         * Returns: ushort list
         */
        public static List<ushort> Sort(List<ushort> numbers)
        {
            List<ushort> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        ushort temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: ushort list
         * Returns: ushort list
         */
        public static List<ushort> Sort(List<ushort> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<ushort> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            ushort temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion

        #region Int
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: int array
         * Returns: int array
         */
        public static int[] Sort(int[] numbers)
        {
            int[] sortedNumbers = numbers;

            for (uint i =0; i<sortedNumbers.Length; i++)
            {
                for (uint i2 =0; i2<sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        int temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: int array
         * Returns: int array
         */
        public static int[] Sort(int[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                int[] sortedNumbers = numbers;

                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            int temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: int list
         * Returns: int list
         */
        public static List<int> Sort(List<int> numbers)
        {
            List<int> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        int temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: int list
         * Returns: int list
         */
        public static List<int> Sort(List<int> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<int> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            int temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion

        #region Uint
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: uint array
         * Returns: uint array
         */
        public static uint[] Sort(uint[] numbers)
        {
            uint[] sortedNumbers = numbers;

            for (uint i = 0; i < sortedNumbers.Length; i++)
            {
                for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        uint temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: uint array
         * Returns: uint array
         */
        public static uint[] Sort(uint[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                uint[] sortedNumbers = numbers;

                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            uint temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: uint list
         * Returns: uint list
         */
        public static List<uint> Sort(List<uint> numbers)
        {
            List<uint> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        uint temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: uint list
         * Returns: uint list
         */
        public static List<uint> Sort(List<uint> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<uint> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            uint temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion

        #region Long
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: long array
         * Returns: long array
         */
        public static long[] Sort(long[] numbers)
        {
            long[] sortedNumbers = numbers;

            for (uint i = 0; i < sortedNumbers.Length; i++)
            {
                for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        long temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: long array
         * Returns: long array
         */
        public static long[] Sort(long[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                long[] sortedNumbers = numbers;

                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            long temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: long list
         * Returns: long list
         */
        public static List<long> Sort(List<long> numbers)
        {
            List<long> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        long temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: long list
         * Returns: long list
         */
        public static List<long> Sort(List<long> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<long> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            long temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion

        #region Ulong
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: ulong array
         * Returns: ulong array
         */
        public static ulong[] Sort(ulong[] numbers)
        {
            ulong[] sortedNumbers = numbers;

            for (uint i = 0; i < sortedNumbers.Length; i++)
            {
                for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        ulong temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: ulong array
         * Returns: ulong array
         */
        public static ulong[] Sort(ulong[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                ulong[] sortedNumbers = numbers;

                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            ulong temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: ulong list
         * Returns: ulong list
         */
        public static List<ulong> Sort(List<ulong> numbers)
        {
            List<ulong> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        ulong temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: ulong list
         * Returns: ulong list
         */
        public static List<ulong> Sort(List<ulong> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<ulong> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            ulong temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion

        #region Float
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: float array
         * Returns: float array
         */
        public static float[] Sort(float[] numbers)
        {
            float[] sortedNumbers = numbers;

            for (uint i = 0; i < sortedNumbers.Length; i++)
            {
                for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        float temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: float array
         * Returns: float array
         */
        public static float[] Sort(float[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                float[] sortedNumbers = numbers;

                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            float temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: float list
         * Returns: float list
         */
        public static List<float> Sort(List<float> numbers)
        {
            List<float> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        float temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: float list
         * Returns: float list
         */
        public static List<float> Sort(List<float> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<float> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            float temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion

        #region Double
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: double array
         * Returns: double array
         */
        public static double[] Sort(double[] numbers)
        {
            double[] sortedNumbers = numbers;

            for (uint i = 0; i < sortedNumbers.Length; i++)
            {
                for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        double temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: double array
         * Returns: double array
         */
        public static double[] Sort(double[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                double[] sortedNumbers = numbers;

                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            double temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: double list
         * Returns: double list
         */
        public static List<double> Sort(List<double> numbers)
        {
            List<double> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        double temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: double list
         * Returns: double list
         */
        public static List<double> Sort(List<double> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<double> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            double temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion

        #region Decimal
        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: decimal array
         * Returns: decimal array
         */
        public static decimal[] Sort(decimal[] numbers)
        {
            decimal[] sortedNumbers = numbers;

            for (uint i = 0; i < sortedNumbers.Length; i++)
            {
                for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        decimal temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: decimal array
         * Returns: decimal array
         */
        public static decimal[] Sort(decimal[] numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                decimal[] sortedNumbers = numbers;

                for (uint i = 0; i < sortedNumbers.Length; i++)
                {
                    for (uint i2 = 0; i2 < sortedNumbers.Length; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            decimal temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest.
         * Parameters: decimal list
         * Returns: decimal list
         */
        public static List<decimal> Sort(List<decimal> numbers)
        {
            List<decimal> sortedNumbers = numbers;

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                {
                    if (sortedNumbers[i] < sortedNumbers[i2])
                    {
                        decimal temp = sortedNumbers[i2];
                        sortedNumbers[i2] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        /*
         * Name: Sort
         * Purpose: Uses bubble sort to sort an array from lowest to highest or vice versa depending on the BubbleSortOptions.
         * Parameters: decimal list
         * Returns: decimal list
         */
        public static List<decimal> Sort(List<decimal> numbers, BubbleSortOptions options)
        {
            if (options == BubbleSortOptions.LowToHigh)
                return Sort(numbers);
            else
            {
                List<decimal> sortedNumbers = numbers;

                for (int i = 0; i < sortedNumbers.Count; i++)
                {
                    for (int i2 = 0; i2 < sortedNumbers.Count; i2++)
                    {
                        if (sortedNumbers[i] > sortedNumbers[i2])
                        {
                            decimal temp = sortedNumbers[i2];
                            sortedNumbers[i2] = sortedNumbers[i];
                            sortedNumbers[i] = temp;
                        }
                    }
                }

                return sortedNumbers;
            }
        }
        #endregion
    }

    enum BubbleSortOptions : sbyte
    {
        LowToHigh,
        HighToLow
    }
}
