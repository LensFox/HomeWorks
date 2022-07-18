using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Calculator
{
    public static class Calculator
    {
        public static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        public static dynamic Ext(dynamic a, dynamic b)
        {
            return a - b;
        }
        public static dynamic Div(dynamic a, dynamic b)
        {
            if (b != 0)
                return a / b;
            else
                return new string("You can't divide be zero");
        }
        public static dynamic Mul(dynamic a, dynamic b)
        {
            return a * b;
        }
    }
}
