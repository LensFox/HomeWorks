using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DynamicArray
{
    internal class DynamicArray<T>
    {
        private T[] data;
        private int count;
        public DynamicArray() :
            this(4)
        {

        }
        public DynamicArray(int size)
        {
            data = new T[size];
            count = 0;
        }
        public void resize()
        {
            int capacity = data.Length == 0 ? 4 : data.Length * 2;
            T[] newArr = new T[capacity];

            data.CopyTo(newArr, 0);
            data = newArr;
        }
        public bool IsFull()
        {
            return count == data.Length;
        }
        public void Add(T item)
        {
            if (this.IsFull())
                this.resize();

            data[count++] = item;
        }
        public void Insert(T item, int index)
        {
            if (index > count)
                return;
            if (this.IsFull())
                this.resize();
            Array.Copy(data, index, data, index + 1, count - index);
            data[index] = item;

            count++;
        }
    }
}
