using System;

namespace _8_GraphTopologicalSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Graph tasks = new Graph(5);
            
            tasks.Add(2, 4, 1);
            tasks.Add(1, 2, 1);
            tasks.Add(0, 2, 1);
            tasks.Add(0, 4, 1);

            var a = tasks.TopologicalSort();

            foreach (var item in a)
                Console.WriteLine(item);
        }
    }
}
