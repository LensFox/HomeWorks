using System;

namespace _6_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What calculation do you want to make?\nEnter  +  -  *  /" +
                "\nS - Square root\nP - Second Power");
            string operation = Console.ReadLine();
            double result;
            switch (operation)
            {
                case "+":
                    {
                        Console.WriteLine("Enter 2 numbers");
                        double numberOne = Convert.ToDouble(Console.ReadLine());
                        double numberTwo = Convert.ToDouble(Console.ReadLine());
                        result = Calculator.Plus(numberOne, numberTwo);
                        IntegerCheckAndShow(result);
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("Enter 2 numbers");
                        int numberOne = Convert.ToInt32(Console.ReadLine());
                        int numberTwo = Convert.ToInt32(Console.ReadLine());
                        result = Calculator.Minus(numberOne, numberTwo);
                        IntegerCheckAndShow(result);
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("Enter 2 numbers");
                        int numberOne = Convert.ToInt32(Console.ReadLine());
                        int numberTwo = Convert.ToInt32(Console.ReadLine());
                        result = Calculator.Divide(numberOne, numberTwo);
                        IntegerCheckAndShow(result);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("Enter 2 numbers");
                        int numberOne = Convert.ToInt32(Console.ReadLine());
                        int numberTwo = Convert.ToInt32(Console.ReadLine());
                        result = Calculator.Multiply(numberOne, numberTwo);
                        IntegerCheckAndShow(result);
                        break;
                    }
                case "S":
                    {
                        Console.WriteLine("Enter your number");
                        double number = Convert.ToDouble(Console.ReadLine());
                        result = Calculator.SquareRoot(number);
                        IntegerCheckAndShow(result);
                        break;
                    }
                case "P":
                    {
                        Console.WriteLine("Enter your number");
                        double number = Convert.ToDouble(Console.ReadLine());
                        result = Calculator.SecondPower(number);
                        IntegerCheckAndShow(result);

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
            }

        }
        internal static void IntegerCheckAndShow(double result)
        {
            double integerResult = Math.Truncate(result);
            double remainder = result - integerResult;
            if (remainder == 0)
            {
                result = Math.Round(result, 0);
                Console.WriteLine(result);
            }
            else
            {
                result = Math.Round(result, 2);
                Console.WriteLine(result);
            }
        }
    }
}
