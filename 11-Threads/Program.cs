using System;
using System.Threading;
using System.Threading.Tasks;

namespace _11_Threads
{
    /*
     Дополнительное задание
Переделайте дополнительное задание из урока №11 с использованием конструкции async
await. 
    
(Используя конструкции блокировки, создайте метод, который будет в цикле for (допустим, на 10
итераций) увеличивать счетчик на единицу и выводить на экран счетчик и текущий поток.
Метод запускается в трех потоках. Каждый поток должен выполниться поочередно, т.е. в
результате на экран должны выводиться числа (значения счетчика) с 1 до 30 по порядку, а не в
произвольном порядке.)
     */
    internal class Program
    {
        static int counter;
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task task1 = new(IncrementCounterAsync);
            Task task2 = new Task(IncrementCounterAsync);
            Task task3 = new Task(IncrementCounterAsync);
            task1.Start();
            await task1;
            task2.Start();
            await task2;
            task3.Start();
            await task3;

        }
        internal async static void IncrementCounterAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                counter++;
                Console.WriteLine("Thread: {0}, Counter: {1}", Thread.CurrentThread.ManagedThreadId, counter);
            }
            await Task.Delay(0);
        }
    }
}
