using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Calculator
{
    internal static class Calculator
    {
        public static double Plus(double a, double b)
        {
            return a + b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        public static double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }
        public static double SecondPower(double a)
        {
            return Math.Pow(a,2);
        }
    }
}
