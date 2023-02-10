using System;
using System.Collections.Generic;
using System.Text;

namespace BallisticModel
{
    public class Vector
    {
        public Vector(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        
        public double X { get; set; }
        public double Y { get; set; }
        public double SqLength
        {
           get => X * X + Y * Y;
        }
        public Vector Normal
        {
            get => new Vector(-Y, X);
        }
        public Vector GetE() => this / GetLength();
        public Vector Projection(Vector OnVector) => (this * OnVector) / (OnVector * OnVector) * OnVector;
        public Vector Mirror(Vector v) => this - 2 * this.Projection(v.Normal);
        public void HorizontalBounce()
        {
            Y = -Y;
        }
        public void VerticalBounce()
        {
            X = -X;
        }
        public double GetLength()
        {
            return Math.Sqrt(SqLength);
        }
        public static double DotProduct(Vector v1, Vector v2)
        {
            return v2.X * v1.X + v1.Y  * v2.Y;
        }
        public Vector Sum(Vector other)
        {
            return new Vector(X + other.X, Y + other.Y);
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        public static Vector operator+(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator-(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }
        public static Vector operator-(Vector a, Vector b)
        {
            return a + (-b);
        }
        public static Vector operator*(double c, Vector v)
        {
            return new Vector(c * v.X, c * v.Y);
        }
        public static Vector operator*(Vector v, double c)
        {
            return c * v;
        }
        public static Vector operator/(Vector v, double c)
        {
            return v * (1 / c);
        }
        public static double operator*(Vector a, Vector b)
        {
            return DotProduct(a, b);
        }
        public override bool Equals(object obj)
        {
            return obj is Vector && this.Equals((Vector)obj);
        }
        public bool Equals(Vector v)
        {
            return v.X == X && v.Y == Y;
        }

        public override int GetHashCode()
        {
            int hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }
    }
}
