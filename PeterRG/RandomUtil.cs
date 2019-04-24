/*
 * 
 * Created by Peter Gorman
 * Util.cs
 * 
 */

using PeterRG.DataTypes;
using System;
using System.Collections.Generic;

namespace PeterRG.RandomUtilities
{
    class RandomArray
    {
        private static readonly Random random = new Random();

        #region Sbyte
        /*
         * Name: Sbyte
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: sbyte array
         */
        public static sbyte[] Sbyte(uint length)
        {
            sbyte[] numbers = new sbyte[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (sbyte)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Sbyte
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: sbyte array
         */
        public static sbyte[] Sbyte(uint length, int maxValue)
        {
            sbyte[] numbers = new sbyte[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (sbyte)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Sbyte
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: sbyte array
         */
        public static sbyte[] Sbyte(uint length, int minValue, int maxValue)
        {
            sbyte[] numbers = new sbyte[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (sbyte)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Byte
        /*
         * Name: Byte
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: byte array
         */
        public static byte[] Byte(uint length)
        {
            byte[] numbers = new byte[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (byte)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Byte
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int
         * Returns: byte array
         */
        public static byte[] Byte(uint length, int maxValue)
        {
            byte[] numbers = new byte[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (byte)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Byte
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int, int
         * Returns: byte array
         */
        public static byte[] Byte(uint length, int minValue, int maxValue)
        {
            byte[] numbers = new byte[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (byte)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Short
        /*
         * Name: Short
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: short array
         */
        public static short[] Short(uint length)
        {
            short[] numbers = new short[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (short)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Short
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int
         * Returns: short array
         */
        public static short[] Short(uint length, int maxValue)
        {
            short[] numbers = new short[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (short)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Short
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int, int
         * Returns: short array
         */
        public static short[] Short(uint length, int minValue, int maxValue)
        {
            short[] numbers = new short[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (short)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Ushort
        /*
         * Name: Ushort
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: ushort array
         */
        public static ushort[] Ushort(uint length)
        {
            ushort[] numbers = new ushort[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (ushort)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Ushort
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int
         * Returns: ushort array
         */
        public static ushort[] Ushort(uint length, int maxValue)
        {
            ushort[] numbers = new ushort[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (ushort)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Ushort
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int, int
         * Returns: ushort array
         */
        public static ushort[] Ushort(uint length, int minValue, int maxValue)
        {
            ushort[] numbers = new ushort[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (ushort)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Int
        /*
         * Name: Int
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: int array
         */
        public static int[] Int(uint length)
        {
            int[] numbers = new int[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = random.Next();
            }

            return numbers;
        }

        /*
         * Name: Int
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int
         * Returns: int array
         */
        public static int[] Int(uint length, int maxValue)
        {
            int[] numbers = new int[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Int
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int, int
         * Returns: int array
         */
        public static int[] Int(uint length, int minValue, int maxValue)
        {
            int[] numbers = new int[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Uint
        /*
         * Name: Uint
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: uint array
         */
        public static uint[] Uint(uint length)
        {
            uint[] numbers = new uint[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (uint)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Uint
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int
         * Returns: uint array
         */
        public static uint[] Uint(uint length, int maxValue)
        {
            uint[] numbers = new uint[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (uint)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Uint
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int, int
         * Returns: uint array
         */
        public static uint[] Uint(uint length, int minValue, int maxValue)
        {
            uint[] numbers = new uint[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (uint)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Long
        /*
         * Name: Long
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: long array
         */
        public static long[] Long(uint length)
        {
            long[] numbers = new long[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = random.Next();
            }

            return numbers;
        }

        /*
         * Name: Long
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int
         * Returns: long array
         */
        public static long[] Long(uint length, int maxValue)
        {
            long[] numbers = new long[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Long
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int, int
         * Returns: long array
         */
        public static long[] Long(uint length, int minValue, int maxValue)
        {
            long[] numbers = new long[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Ulong
        /*
         * Name: Ulong
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: ulong array
         */
        public static ulong[] Ulong(uint length)
        {
            ulong[] numbers = new ulong[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (ulong)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Ulong
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int
         * Returns: ulong array
         */
        public static ulong[] Ulong(uint length, int maxValue)
        {
            ulong[] numbers = new ulong[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (ulong)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Ulong
         * Purpose: Produces an array of random numbers.
         * Parameters: uint, int, int
         * Returns: ulong array
         */
        public static ulong[] Ulong(uint length, int minValue, int maxValue)
        {
            ulong[] numbers = new ulong[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (ulong)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Float
        /*
         * Name: Float
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: float array
         */
        public static float[] Float(uint length)
        {
            float[] numbers = new float[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (float)random.NextDouble();
            }

            return numbers;
        }
        #endregion

        #region Double
        /*
         * Name: Double
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: double array
         */
        public static double[] Double(uint length)
        {
            double[] numbers = new double[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = random.NextDouble();
            }

            return numbers;
        }
        #endregion

        #region Decimal
        /*
         * Name: Decimal
         * Purpose: Produces an array of random numbers.
         * Parameters: uint
         * Returns: decimal array
         */
        public static decimal[] Decimal(uint length)
        {
            decimal[] numbers = new decimal[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = (decimal)random.NextDouble();
            }

            return numbers;
        }
        #endregion

        #region Vector2
        /*
         * Name: Vector2
         * Purpose: Produces an array of random vectors.
         * Parameters: uint
         * Returns: Vector2 array
         */
        public static Vector2[] Vector2(uint length)
        {
            Vector2[] numbers = new Vector2[length];

            for (uint i = 0; i < length; i++)
            {
                numbers[i] = new Vector2(random.NextDouble(), random.NextDouble());
            }

            return numbers;
        }
        #endregion
    }

    class RandomList
    {
        private static readonly Random random = new Random();

        #region Sbyte
        /*
         * Name: Sbyte
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: sbyte list
         */
        public static List<sbyte> Sbyte(int length)
        {
            List<sbyte> numbers = new List<sbyte>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (sbyte)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Sbyte
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int
         * Returns: sbyte list
         */
        public static List<sbyte> Sbyte(int length, int maxValue)
        {
            List<sbyte> numbers = new List<sbyte>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (sbyte)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Sbyte
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int, int
         * Returns: sbyte list
         */
        public static List<sbyte> Sbyte(int length, int minValue, int maxValue)
        {
            List<sbyte> numbers = new List<sbyte>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (sbyte)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Byte
        /*
         * Name: Byte
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: byte list
         */
        public static List<byte> Byte(int length)
        {
            List<byte> numbers = new List<byte>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (byte)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Byte
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int
         * Returns: byte list
         */
        public static List<byte> Byte(int length, int maxValue)
        {
            List<byte> numbers = new List<byte>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (byte)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Byte
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int, int
         * Returns: byte list
         */
        public static List<byte> Byte(int length, int minValue, int maxValue)
        {
            List<byte> numbers = new List<byte>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (byte)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Short
        /*
         * Name: Short
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: short list
         */
        public static List<short> Short(int length)
        {
            List<short> numbers = new List<short>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (short)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Short
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int
         * Returns: short list
         */
        public static List<short> Short(int length, int maxValue)
        {
            List<short> numbers = new List<short>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (short)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Short
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int, int
         * Returns: short list
         */
        public static List<short> Short(int length, int minValue, int maxValue)
        {
            List<short> numbers = new List<short>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (short)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Ushort
        /*
         * Name: Ushort
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: ushort list
         */
        public static List<ushort> Ushort(int length)
        {
            List<ushort> numbers = new List<ushort>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (ushort)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Ushort
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int
         * Returns: ushort list
         */
        public static List<ushort> Ushort(int length, int maxValue)
        {
            List<ushort> numbers = new List<ushort>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (ushort)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Ushort
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int, int
         * Returns: ushort list
         */
        public static List<ushort> Ushort(int length, int minValue, int maxValue)
        {
            List<ushort> numbers = new List<ushort>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (ushort)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Int
        /*
         * Name: Int
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: int list
         */
        public static List<int> Int(int length)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next();
            }

            return numbers;
        }

        /*
         * Name: Int
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int
         * Returns: int list
         */
        public static List<int> Int(int length, int maxValue)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Int
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int, int
         * Returns: int list
         */
        public static List<int> Int(int length, int minValue, int maxValue)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Uint
        /*
         * Name: Uint
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: uint list
         */
        public static List<uint> Uint(int length)
        {
            List<uint> numbers = new List<uint>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (uint)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Uint
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int
         * Returns: uint list
         */
        public static List<uint> Uint(int length, int maxValue)
        {
            List<uint> numbers = new List<uint>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (uint)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Uint
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int, int
         * Returns: uint list
         */
        public static List<uint> Uint(int length, int minValue, int maxValue)
        {
            List<uint> numbers = new List<uint>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (uint)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Long
        /*
         * Name: Long
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: long list
         */
        public static List<long> Long(int length)
        {
            List<long> numbers = new List<long>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next();
            }

            return numbers;
        }

        /*
         * Name: Long
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int
         * Returns: long list
         */
        public static List<long> Long(int length, int maxValue)
        {
            List<long> numbers = new List<long>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Long
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int, int
         * Returns: long list
         */
        public static List<long> Long(int length, int minValue, int maxValue)
        {
            List<long> numbers = new List<long>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Ulong
        /*
         * Name: Ulong
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: ulong list
         */
        public static List<ulong> Ulong(int length)
        {
            List<ulong> numbers = new List<ulong>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (ulong)random.Next();
            }

            return numbers;
        }

        /*
         * Name: Ulong
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int
         * Returns: ulong list
         */
        public static List<ulong> Ulong(int length, int maxValue)
        {
            List<ulong> numbers = new List<ulong>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (ulong)random.Next(maxValue);
            }

            return numbers;
        }

        /*
         * Name: Ulong
         * Purpose: Produces a list of random numbers.
         * Parameters: int, int, int
         * Returns: ulong list
         */
        public static List<ulong> Ulong(int length, int minValue, int maxValue)
        {
            List<ulong> numbers = new List<ulong>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (ulong)random.Next(minValue, maxValue);
            }

            return numbers;
        }
        #endregion

        #region Float
        /*
         * Name: Float
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: float list
         */
        public static List<float> Float(int length)
        {
            List<float> numbers = new List<float>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (float)random.NextDouble();
            }

            return numbers;
        }
        #endregion

        #region Double
        /*
         * Name: Double
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: double list
         */
        public static List<double> Double(int length)
        {
            List<double> numbers = new List<double>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.NextDouble();
            }

            return numbers;
        }
        #endregion

        #region Decimal
        /*
         * Name: Decimal
         * Purpose: Produces a list of random numbers.
         * Parameters: int
         * Returns: decimal list
         */
        public static List<decimal> Decimal(int length)
        {
            List<decimal> numbers = new List<decimal>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = (decimal)random.NextDouble();
            }

            return numbers;
        }
        #endregion

        #region Vector2
        /*
         * Name: Vector2
         * Purpose: Produces a list of random vectors.
         * Parameters: int
         * Returns: Vector2 list
         */
        public static List<Vector2> Vector2(int length)
        {
            List<Vector2> numbers = new List<Vector2>();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = new Vector2(random.NextDouble(), random.NextDouble());
            }

            return numbers;
        }
        #endregion
    }
}
