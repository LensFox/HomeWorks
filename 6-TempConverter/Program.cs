using System;

namespace _6_TempConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while (a)
            {
                Console.WriteLine("Hello! What would you like to convert?\nPress\n" +
                    "1 - Celcius to Fahrenheit\n" +
                    "2 - Fahrenheit to Celsius\n" +
                    "3 - Celsius to Kelvin\n" +
                    "4 - Kelvin to Celsius\n" +
                    "5 - Celsius to Reaumur\n" +
                    "6 - Reaumur to Celsius\n" +
                    "0 - quit");
                string userChoice = Console.ReadLine();
                Console.WriteLine("Enter the temperature");
                double temp = Convert.ToDouble(Console.ReadLine());

                switch (userChoice)
                {
                    case "1":
                        {
                            Converter.CtoF(temp);
                            break;
                        }
                    case "2":
                        {
                            Converter.FtoC(temp);
                            break;
                        }
                    case "3":
                        {
                            Converter.CtoK(temp);
                            break;
                        }
                    case "4":
                        {
                            Converter.KtoC(temp);
                            break;
                        }
                    case "5":
                        {
                            Converter.CtoR(temp);
                            break;
                        }
                    case "6":
                        {
                            Converter.RtoC(temp);
                            break;
                        }
                    case "0":
                        {
                            a = false;
                            break;
                        }

                    default:
                        Console.WriteLine("Impossible to convert");
                        break;
                }
            }
        }
    }
}
