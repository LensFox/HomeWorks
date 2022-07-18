using System;
using System.Collections;
using System.Collections.Generic;

namespace _14_EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new int[20];
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1, 1000);
            }
            //List<int> evenNumbers = new List<int>();
            //evenNumbers.AddRange(Method(a));
            //evenNumbers = (List<int>)Method(a);
            //Console.WriteLine(Method(a));

            var elements = Method(a);
            foreach (int element in elements)
            {
                Console.WriteLine(element);
            }

        }
        public static IEnumerable<int> Method(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 == 0)
                    yield return a[i];
        }
    }
}
