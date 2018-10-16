using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    public class Vector
    {
        public Vector() : this(0, 0) { }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        double X { get; set; }
        double Y { get; set; }

        public static Vector operator +(Vector first, Vector second) => new Vector(first.X + second.X, first.Y + second.Y);
        public static Vector operator -(Vector first, Vector second) => new Vector(first.X - second.X, first.Y - second.Y);
        public static Vector operator -(Vector vector) => new Vector(-vector.X, -vector.Y);
        public static double operator *(Vector vector1, Vector vector2) => vector1.X * vector2.X + vector1.Y * vector2.Y;
        public static Vector operator *(Vector vector, double koefficient) => new Vector(vector.X * koefficient, vector.Y * koefficient);
        public static Vector operator *(double koefficient, Vector vector) => vector * koefficient;
        public static bool operator ==(Vector vector1, Vector vector2) => (vector1.X == vector2.X && vector1.Y == vector2.Y);
        public static bool operator !=(Vector vector1, Vector vector2) => !(vector1 == vector2);

        public static Vector operator /(Vector vector, double koefficient)
        {
            if (koefficient == 0) throw new ArgumentNullException("На ноль делить нельзя!");
            return new Vector(vector.X / koefficient, vector.Y / koefficient);
        }
        public override int GetHashCode() => 17 * X.GetHashCode() + Y.GetHashCode();

        public double Length => Math.Sqrt(X * X + Y * Y);

        public override string ToString() => $"X={X}, Y={Y}";

        public bool IsZero => (X == 0 && Y == 0);
        public static Vector Zero => new Vector(0, 0);
        public Vector Normalize()
        {
            if (IsZero) return Zero;
            return new Vector(X / Length, Y / Length);
        }
    }
}
