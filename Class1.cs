using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorLibrary;

namespace VectorTest
{
    public class Class1
    {
        public static void Main()
        {
            Vector a = new Vector(1, 2);
            Vector b = new Vector(2, 4);
            //print("a", a);
            //print("b", b);
            print2(a, b);
            //print("2a+3b", 2 * a + 3 * b);
            print2(2 * a, b * 3);

            Console.ReadKey();
        }

        private static void print(string title, Vector vector)
        {
            Console.WriteLine(title);
            Console.WriteLine("\tVector: " + vector);
            Console.WriteLine("\t-Vector: " + -vector);
            Console.WriteLine("\tLength: " + vector.Length);
            Console.WriteLine("\tNorm: " + vector.Normalize());
            Console.WriteLine("\tIsZero: " + vector.IsZero);
            Console.WriteLine("\tHash: " + vector.GetHashCode());
        }

        private static void print2(Vector vector1, Vector vector2)
        {
            Console.WriteLine("Two vectors");
            print("first", vector1);
            print("second", vector2);
            print("+", vector1 + vector2);
            print("-", vector1 - vector2);
            Console.WriteLine("\t*: "+ vector1 * vector2);
        }
    }
}
