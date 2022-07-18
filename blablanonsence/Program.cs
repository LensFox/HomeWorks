using System;
using System.Collections.Generic;

namespace blablanonsence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Alice");
            list.AddLast("went");
            list.AddLast("into");
            list.AddLast("the rabbit hole");
            foreach (string item in list)
                Console.WriteLine(item);

            list.Remove("went");

            foreach (string item in list)
                Console.WriteLine(item);

        }
    }
}
