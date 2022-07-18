using System;
using System.Globalization;

namespace _6_DecimalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter your number");
            string inputNumber = "15.66";
            CultureInfo culture = CultureInfo.InvariantCulture;
            NumberStyles numberStyles = NumberStyles.Number;
            if (Decimal.TryParse(inputNumber, numberStyles, culture, out decimal number))
            {
                number = Convert.ToDecimal(inputNumber);
                decimal result = number.Calculate();
                Console.WriteLine($"To the following integer: {result}");
            }
            else
                Console.WriteLine("Wrong input");
        }
    }
}
