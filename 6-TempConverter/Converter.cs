using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TempConverter
{
    public static class Converter
    {
        public static void CtoF(double c)
        {
            double result = (9.0 / 5.0 * c) + 32;
            IntegerCheckAndShow(result);
        }
        public static void FtoC(double f)
        {
            double result = 5.0 / 9.0 * (f - 32);
            IntegerCheckAndShow(result);
        }
        public static void CtoK(double c)
        {
            double result = c + 273.15;
            Console.WriteLine(Math.Round(result, 2));
        }
        public static void KtoC(double k)
        {
            double result = k - 273.15;
            Console.WriteLine(Math.Round(result, 2));
        }
        public static void CtoR(double c)
        {
            double result = c * 0.8;
            IntegerCheckAndShow(result);
        }
        public static void RtoC(double r)
        {
            double result = r / 0.8;
            IntegerCheckAndShow(result);
        }
        private static void IntegerCheckAndShow(double result)
        {
            double integerResult = Math.Truncate(result);
            double remainder = result - integerResult;
            if (remainder == 0)
            {
                result = Math.Round(result, 0);
                Console.WriteLine(result);
            }
            else
            {
                result = Math.Round(result, 2);
                Console.WriteLine(result);
            }
        }
    }
}
