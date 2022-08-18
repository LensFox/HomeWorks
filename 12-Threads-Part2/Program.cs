using System.IO;
using System.Threading;

namespace _12_Threads_Part2
{
    /*
     Дополнительное задание
Создайте Semaphore, осуществляющий контроль доступа к ресурсу из нескольких потоков.
Организуйте упорядоченный вывод информации о получении доступа в специальный *.log
файл. 
     */
    internal class Program
    {
        static Semaphore _pool;
        static readonly string _path = @"F:\Tests\Threads.log";
        static void Main(string[] args)
        {
            _pool = new Semaphore(1, 5, "MySemaphore"); //работает только с одним потоком
            for (int i = 0; i < 3; i++)
            {
                new Thread(Method).Start(i);
            }
        }
        static void Method(object i)
        {
            _pool.WaitOne();
            var writer = new StreamWriter(_path, true);
            writer.WriteLine($"Stream {i} worked");
            writer.Close();
            _pool.Release();
        }
    }
}
