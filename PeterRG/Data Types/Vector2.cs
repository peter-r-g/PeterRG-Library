/*
 * 
 * Created by Peter Gorman
 * Vector2.cs
 * 
 */

using PeterRG.MathUtilities;
using System;

namespace PeterRG.DataTypes
{
    class Vector2
    {
        #region Variables
        public bool isVector2 { private set; get; } = false;
        public double x, y;
        #endregion

        #region Constructors
        public Vector2()
        {
            this.isVector2 = true;
            this.x = 0;
            this.y = 0;
        }

        public Vector2(double x, double y)
        {
            this.isVector2 = true;
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Overrides
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Vector2 vec = (Vector2)obj;

            if (vec != null && vec.isVector2)
            {
                if (this.x == vec.x && this.y == vec.y)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return $"Vector2: X={this.x}, Y={this.y}";
        }
        #endregion

        #region Operators
        public static Vector2 operator+ (Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator- (Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }

        public static Vector2 operator* (Vector2 a, Vector2 b)
        {
            return new Vector2(a.x * b.x, a.y * b.y);
        }

        public static Vector2 operator/ (Vector2 a, Vector2 b)
        {
            return new Vector2(a.x / b.x, a.y / b.y);
        }

        public static bool operator == (Vector2 a, Vector2 b)
        {
            if (a.x == b.x && a.y == b.y)
                return true;
            else
                return false;
        }

        public static bool operator != (Vector2 a, Vector2 b)
        {
            if (a.x != b.x || a.y != b.y)
                return true;
            else
                return false;
        }
        #endregion

        #region Static Functions
        public static Vector2 Zero()
        {
            return new Vector2();
        }

        public static double Magnitude(Vector2 a)
        {
            return Math.Sqrt(Math.Pow(a.x, 2) + Math.Pow(a.y, 2));
        }

        public static double CrossProduct(Vector2 a, Vector2 b)
        {
            return (a.x * b.y) - (a.y * b.x);
        }

        public static double DotProduct(Vector2 a, Vector2 b)
        {
            return (a.x * a.y) + (b.x * b.y);
        }

        public static double AngleBetween(Vector2 a, Vector2 b)
        {
            double sin = CrossProduct(a, b);
            double cos = DotProduct(a, b);

            return MathUtil.RadianToDegree(Math.Atan2(sin, cos));
        }

        public static Vector2 Normalize(Vector2 a)
        {
            double mag = Magnitude(a);
            return new Vector2(a.x / mag, a.y / mag);
        }

        public static double Distance(Vector2 a, Vector2 b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
        }

        public static double DistanceNoSqrt(Vector2 a, Vector2 b)
        {
            return Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2);
        }
        #endregion
    }
}
