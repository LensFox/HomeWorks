using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DecimalNumbers
{
    internal static class ToCalculator
    {
        public static decimal Calculate(this decimal number)
        {
            decimal a = Math.Truncate(number) + 1;
            return a - number;

        }
    }
}
