using System;
using System.Threading;

namespace _11_Threads
{
    /*
     Дополнительное задание
Используя конструкции блокировки, создайте метод, который будет в цикле for (допустим, на 10
итераций) увеличивать счетчик на единицу и выводить на экран счетчик и текущий поток.
Метод запускается в трех потоках. Каждый поток должен выполниться поочередно, т.е. в
результате на экран должны выводиться числа (значения счетчика) с 1 до 30 по порядку, а не в
произвольном порядке.
     */
    internal class Program
    {
        static int counter;
        static object block = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Thread thread1 = new Thread(new ThreadStart(IncrementCounter));
            Thread thread2 = new Thread(new ThreadStart(IncrementCounter));
            IncrementCounter();
            thread1.Start();
            thread2.Start();
        }
        internal static void IncrementCounter()
        {
            lock (block)
            {
                for (int i = 0; i < 10; i++)
                {
                    counter++;
                    Console.WriteLine("Thread: {0}, Counter: {1}", Thread.CurrentThread.ManagedThreadId, counter);
                }
            }
        }
    }
}
