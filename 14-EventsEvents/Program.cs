using System;

namespace _14_EventsEvents
{
    internal class Program
    {
        static void JustDoIt(string message, int counter)
        {
            Console.WriteLine($"Event message: {message}, iteration number: {counter}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EventHandler smth = new EventHandler();
            //int counter = 0;
            smth.Starter += smth.StarterMethod;
            smth.One += JustDoIt;
            smth.Two += JustDoIt;
            smth.Three += JustDoIt;
            smth.Four += JustDoIt;
            smth.Five += JustDoIt;
            smth.Six += JustDoIt;

            smth.InvokeStarter();
        }
    }
}
