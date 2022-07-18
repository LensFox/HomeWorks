using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static object block = new object();
        //static object block1 = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ThreadStart one = new ThreadStart(One);
            ThreadStart two = new ThreadStart(Two);
            ThreadStart three = new ThreadStart(Three);
            Thread threadOne = new Thread(One);
            Thread threadTwo = new Thread(Two);
            Thread threadThree = new Thread(Three);

            threadOne.Start();
            threadTwo.Start();
            threadThree.Start();

            //threadOne.Join(2000);

            Random random = new Random();
            while (true)
            {
                
                lock (block)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    for (int i = 0; i < 19; i++)
                        Console.WriteLine(new string(' ', 6) + random.Next(100, 1300).ToString("X"));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', 6) + random.Next(100, 1300).ToString("X"));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(new string(' ', 6) + random.Next(100, 1300).ToString("X"));
                    Thread.Sleep(600);
                }
            }

        }
        static void One()
        {
            Random random = new Random();
            while (true)
            {
                lock (block)
                {
                    
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    for (int i = 0; i < 15; i++)
                        Console.WriteLine(new string(' ', 20) + random.Next(805, 2900).ToString("X"));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', 20) + random.Next(805, 2900).ToString("X"));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(new string(' ', 20) + random.Next(805, 2900).ToString("X"));
                    Thread.Sleep(600);
                }
            }
        }
        static void Two()
        {
            Random random = new Random();
            while (true)
                {
                lock (block)
                {
                    
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    for (int i = 0; i < 9; i++)
                        Console.WriteLine(new string(' ', 48) + random.Next(102, 1450).ToString("X"));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', 48) + random.Next(102, 1450).ToString("X"));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(new string(' ', 48) + random.Next(102, 1450).ToString("X"));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Thread.Sleep(600);
                }
            }
        }
        static void Three()
        {
            Random random = new Random();
            while (true)
            {
                lock (block)
                {
                    
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    for (int i = 0; i < 22; i++)
                        Console.WriteLine(new string(' ', 70) + random.Next(330, 3755).ToString("X"));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', 70) + random.Next(330, 3755).ToString("X"));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(new string(' ', 70) + random.Next(330, 3755).ToString("X"));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Thread.Sleep(600);
                }
            }
        }
    }
}
