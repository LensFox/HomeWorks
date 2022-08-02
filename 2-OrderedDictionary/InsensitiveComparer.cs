using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OrderedDictionary
{
    internal class InsensitiveComparer : IEqualityComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }
        public new bool Equals(object x, object y)
        {
            return comparer.Compare(x, y) == 0;
        }
    }
}
