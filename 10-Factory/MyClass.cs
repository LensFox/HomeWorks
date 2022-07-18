using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory
{
    internal class MyClass<T>
    {
        public static T FactoryMethod()
        {
            T a = default;
            return a;
        }
    }
}
