using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal static class Extension
    {
        public static T[] GetArray<T> (this MyList<T> list)
        {
            //for (int i = 0; i < list.a.Length; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            return list.a.ToArray ();
        }
    }
}
