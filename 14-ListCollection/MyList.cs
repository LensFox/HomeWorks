using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _14_ListCollection
{
    internal class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        T[] list { set { _list = value; } get { return _list; } }
        T[] _list;
        public int position = -1;
        public int Count
        { get { return list.Length; } }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public T Current
        {
            get
            {
                try
                {
                    return list[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        public MyList(T value)
        {
            list = new T[1];
            list[0] = value;
        }
        public MyList()
        {

        }
        public void Reset()
        {
            position = -1;
        }
        public bool MoveNext()
        {
            if (position < list.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }
        
        public T this[int i]
        {
            get
            {
                return list[i];
            }
        }
        public void Add(T value)
        {
            if (list != null)
            {
                T[] newList = new T[list.Length + 1];
                for (int i = 0; i < list.Length; i++)
                {
                    newList[i] = list[i];
                }

                newList[newList.Length - 1] = value;

                list = newList;
            }

            else
            {
                list = new T[] { value };
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose"); 
        }
    }
}
