using System;
using System.Collections;
using System.Collections.Generic;

namespace _14_ListCollection
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyList<double> list = new MyList<double>();
            list.Add(4.07);
            Console.WriteLine(list[0]);
            list.Add(6.44);
            list.Add(34.94);
            list.Add(55.82);
            foreach (var item in list)
                Console.WriteLine(item);
            Console.WriteLine(list.Count);
            
            double[] list2 = list.GetArray<double>();
            foreach (var item in list2)
                Console.WriteLine(item);
        }
        
    }
}
