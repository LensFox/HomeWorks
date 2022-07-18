using System;
using System.Collections;

namespace _11_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayList smth = new ArrayList();
            int age = 29;
            string name = "Lena";
            smth.Add(name);
            smth.Add(age);
            for (int i = 0; i < smth.Count; i++)
            {
                Console.WriteLine(smth[i]);
            }
        }
    }
}
