using System;
using System.Threading.Tasks;
using System.Threading;

namespace _13_Asynchronous
{
    /*
    Задание 2
Создайте консольное приложение, в котором организуйте асинхронный вызов метода.
Используя конструкцию BeginInvoke передайте в поток некоторую информацию (возможно, в
формате строки). Организуйте обработку переданных данных в callback методе. 
     */
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Func<string, string> func = new Func<string, string>(AddString);
            string result = Task.Run(() => func("Bla-bla")).Result;
            var a = await Callback(result);
            //var b = await Method(a);
            Console.WriteLine(a);
        }
        static string AddString(string s)
        {
            s += " 1";
            return s;
        }
        static async Task<string> Callback(string s)
        {
            Thread.Sleep(3000);
            return s + " callback";
        }
    }
}
