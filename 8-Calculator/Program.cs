using System;

namespace _8_Calculator
{
    internal class Program
    {
        public delegate int? Operation(int x, int y);
        static void Main(string[] args)
        {
            Operation add = delegate (int x, int y) { return x + y; };
            Operation subtract = delegate (int x, int y) { return x - y; };
            Operation multiply = delegate (int x, int y) { return x * y; };
            Operation divide = delegate (int x, int y)
            {
                if (y == 0)
                {
                    Console.WriteLine("You can't divide by zero!");//why is it at the beginning?
                    return null;
                }
                else
                    return x / y;
            };
            Console.WriteLine("Hello!");
            var adding = add(26, 1);
            var substracting = subtract(26, 1);
            var multiplying = multiply(26, 2);
            var dividing = divide(26, 10);
            var dividingByZero = divide(26, 0);
            Console.WriteLine("The results\n" +
                $"Adding: {adding}\nSubstracting: {substracting}\nMultiplying:{multiplying}\n" +
                $"Dividing: {dividing}\nAnother dividing: {dividingByZero}");
        }
    }
}
