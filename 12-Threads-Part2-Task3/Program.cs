using System;
using System.Threading;

namespace _12_Threads_Part2_Task3
{
    /*
    Задание 3
Создайте приложение, которое может быть запущено только в одном экземпляре (используя
именованный Mutex).  
     */
    internal class Program
    {
        static Mutex mutex = new Mutex(false, "MyMutex");
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 4; i++)
            {
                new Thread(Method).Start(i);
            }
        }
        static void Method(object i)
        {
            mutex.WaitOne();
            Console.WriteLine("Thread {0} worked", i);
            mutex.ReleaseMutex();
        }
    }
}
