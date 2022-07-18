using System;
using System.Linq;

namespace _17_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(32,88));
            Console.WriteLine(Calculator.Ext(32, 88));
            Console.WriteLine(Calculator.Div(32, 88));
            Console.WriteLine(Calculator.Div(32, 0));
            Console.WriteLine(Calculator.Mul(32, 88));
        }
    }
}
