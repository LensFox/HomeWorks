using System;
using System.Threading.Tasks;

namespace _15_Async
{
    /*
     консольное приложение, старт по нажатию ENTER, запускается таймер на 3 с, по истечению времени,
    выводит сообщение в консоль, проходит 3 секунды, выводит другое сообщение в консоль, ещё 2 секунды
    и новое сообщение 
     */
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.ReadLine();
           
            await PrintMessage("Hello, ", 3000);
            await PrintMessage("Kostya", 3000);
            await PrintMessage("!!!", 2000);

        }
        static async Task PrintMessage(string message, int delay)
        {
            await Task.Delay(delay);
            Console.Write(message);
        }

    }
}
