using System;

namespace _6_ArraySorting
{
    public static class Program //is static ok?
    {
        static void Main(string[] args)
        {
           Sort(Prices.a);
            for (int i = 0; i < Prices.a.Length; i++)
                Console.WriteLine(Prices.a[i]);
            Prices c = new Prices(5);
            Console.WriteLine(c.FindValue(c.b));
        }
        public static void Sort(this int[] a)
        {
            Array.Sort(a);
        }

    }
}
