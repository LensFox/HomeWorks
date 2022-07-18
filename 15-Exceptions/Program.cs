using System;

namespace _15_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            int aa = 0;
            string b;
            int bb = 0;
            string operation = null;
            while (true)
            {
            Label:
                Console.WriteLine("Hello! Choose the operation\n" +
                    "+\n-\n*\n/");
                operation = Console.ReadLine();
                try
                {
                    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    {
                        throw new Exception("Unknown operation. Try again.");
                        //Console.WriteLine("Unknown operation. Try again.");
                        //goto Label;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    goto Label;
                }
            Label2:
                Console.WriteLine("Enter the first number");
                a = Console.ReadLine();
                try
                {
                    aa = int.Parse(a);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Label2;
                }

                Label3:
                Console.WriteLine("Enter the second number");
                b = Console.ReadLine();
                try
                {
                    bb = int.Parse(b);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Label3;
                }

                switch (operation)
                {
                    case "+":
                        {
                            Calculator.Add(aa, bb);
                            break;
                        }
                    case "-":
                        {
                            Calculator.Sub(aa, bb);
                            break;
                        }
                    case "*":
                        {
                            Calculator.Mul(aa, bb);
                            break;
                        }
                    case "/":
                        {
                            Calculator.Div(aa, bb);
                            break;
                        }
                    default:
                        {
                            throw new Exception("Unknown operation");
                        }
                }
            }
        }
    }
}
