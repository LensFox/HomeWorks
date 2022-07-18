using System;

namespace _9_Anonymous
{
    public delegate int Calculations(int a, int b, int c);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculations average = delegate (int a, int b, int c) { return (a + b + c) / 3; };
            var r = average(5, 6, 7);
            var e = average(34, 4846, 734);
            Console.WriteLine($"Results: {r}, {e}");
        }
    }
}
