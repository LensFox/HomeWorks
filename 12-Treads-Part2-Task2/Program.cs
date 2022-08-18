using System;
using System.Threading;

namespace _12_Treads_Part2_Task2
{
    /*
     Задание 2
Преобразуйте пример событийной блокировки таким образом, чтобы вместо ручной обработки
использовалась автоматическая. 
     */
    internal class Program
    {
        static AutoResetEvent auto = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread thread = new Thread(Method);
            thread.Start();
            Console.ReadLine();
            auto.Set();
        }
        static void Method()
        {
            Console.WriteLine("I do smth");
            auto.WaitOne();
            Console.WriteLine("I keep doing smth");
        }
    }
}
