using System;

namespace _6_GraphsCities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph roadMap = new Graph(6);
            roadMap.Add(0, 1, 1);
            roadMap.Add(1, 2, 1);
            roadMap.Add(2, 3, 1);
            roadMap.Add(2, 4, 1);
            roadMap.Add(4, 5, 1);

            Console.WriteLine($"Number of roads: {roadMap.Count}");

            roadMap.Add(0, 1, 0);
            roadMap.Add(1, 2, 0);
            roadMap.Add(2, 5, 0);

            Console.WriteLine($"Number of roads: {roadMap.Count}");

            roadMap.Add(3, 2, 1);
            roadMap.Add(2, 1, 0);

            Console.WriteLine($"Number of roads: {roadMap.Count}");
        }
    }
}
