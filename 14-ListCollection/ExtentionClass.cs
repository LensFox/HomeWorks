using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ListCollection
{
    public static class ExtentionClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            return list.ToArray();
        }

    }
}
