using System;

namespace _7_TheShortestPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph roadMap = new Graph(5);
            roadMap.Add(0, 1, 350);
            roadMap.Add(0, 2, 200);
            roadMap.Add(0, 4, 400);
            roadMap.Add(1, 0, 350);
            roadMap.Add(1, 4, 50);
            roadMap.Add(2, 0, 200);
            roadMap.Add(2, 3, 150);
            roadMap.Add(3, 2, 150);
            roadMap.Add(3, 4, 500);
            roadMap.Add(4, 0, 400);
            roadMap.Add(4, 1, 50);
            roadMap.Add(4, 3, 500);

            var a = roadMap.GetTheShortestPath(3);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
