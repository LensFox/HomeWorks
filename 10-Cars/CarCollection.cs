using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cars
{
    public class CarCollection<T>
    {
        ArrayList carsCollection = new ArrayList();
        public int Count { get { return carsCollection.Count; } } 
        public CarCollection(T a)
        {
            carsCollection.Add(a);
        }
        public CarCollection(T a, T b)
        {
            carsCollection.Add(a);
            carsCollection.Add(b);
        }
        public CarCollection(T a, T b, T c)
        {
            carsCollection[0] = a;
            carsCollection[1] = b;
            carsCollection[2] = c;
        }
        public CarCollection(T a, T b, T c, T d)
        {
            carsCollection[0] = a;
            carsCollection[1] = b;
            carsCollection[2] = c;
            carsCollection[3] = d;
        }
        public CarCollection(T a, T b, T c, T d, T e)
        {
            carsCollection[0] = a;
            carsCollection[1] = b;
            carsCollection[2] = c;
            carsCollection[3] = d;
            carsCollection[4] = e;
        }
        public CarCollection(T a, T b, T c, T d, T e, T f)
        {
            carsCollection[0] = a;
            carsCollection[1] = b;
            carsCollection[2] = c;
            carsCollection[3] = d;
            carsCollection[4] = e;
            carsCollection[5] = f;
        }
        public T this[int index]
        {
            get { return (T)carsCollection[index]; }
            set { carsCollection[index] = value; }
        }
        public void Add (T item)
        {
            carsCollection.Add(item);
        }
    }
}
