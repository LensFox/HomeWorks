using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Exceptions
{
    public static class Calculator
    {
        public static void Add(int a, int b)
        {
            //Console.Write(a + "U+002CU+0020" + b);
            Console.WriteLine($"Result:{a + b}\n");
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine($"Result:{a - b}\n");
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine($"Result:{a * b}\n");
        }
        public static void Div(int a, int b)
        {
            try
            {
                Console.WriteLine($"Result:{a / b}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
