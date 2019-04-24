/*
 * 
 * Created by Peter Gorman
 * MathUtil.cs
 * 
 */

using System;

namespace PeterRG.MathUtilities
{
    class MathUtil
    {
        public static double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        public static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
