using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ArraySorting
{
    public class Prices
    {
        public static int[] a;
        public int b;
        static Prices()
        {
            a = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                a[i] = random.Next(0, 100);
        }
        public Prices(int b)
        {
            this.b = b;
        }
        public int FindValue(int b)
        {
            return a[b];
        }
    }
}
