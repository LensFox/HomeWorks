using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class MyList<T>
    {
        public T[] a;
        public int numberOfElements
        {
            get
            {
                return a.Length;
            }
        }
        public MyList(int length)
        {
            a = new T[length];
        }
        public T this[int index]
        {
            get { return a[index]; }
            set { a[index] = value; }
        }
        public T[] Add(T point)
        {
            int length = a.Length + 1;
            T[] b = new T[length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            b[length - 1] = point;
            a = b;
            return a;
        }

    }
}
