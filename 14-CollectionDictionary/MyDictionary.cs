using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CollectionDictionary
{
    public class MyDictionary<TKey, TValue> : IEnumerator, IEnumerable
    {
        TKey[] keys;
        TValue[] values;
        MyDictionary<TKey[], TValue[]> list;
        int position = -1;
        public int Count
        { get { return keys.Length; } }
        
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public string Current
        {
            get
            {
                try
                {
                    return string.Format($"{keys[position]} - {values[position]}");
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        public MyDictionary(TKey key, TValue value)
        {
            keys = new TKey[1];
            keys[0] = key;
            values = new TValue[1];
            values[0] = value;
        }
        public MyDictionary()
        {

        }
        public void Reset()
        {
            position = -1;
        }
        public bool MoveNext()
        {
            if (position < keys.Length - 1)
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
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        public string this[TKey userKey]
        {
            get
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].Equals(userKey))
                        return string.Format($"{keys[i]} - {values[i]}");
                }

                return "NotFound";
            }
        }
        public void Add(TKey key, TValue value)
        {
            if (keys != null && values != null)
            {
                TKey[] newKeys = new TKey[keys.Length + 1];
                for (int i = 0; i < keys.Length; i++)
                {
                    newKeys[i] = keys[i];
                }

                newKeys[newKeys.Length - 1] = key;
                TValue[] newValues = new TValue[values.Length + 1];
                for (int i = 0; i < values.Length; i++)
                {
                    newValues[i] = values[i];
                }

                newValues[newValues.Length - 1] = value;
                keys = newKeys;
                values = newValues;
            }
            else
            {
                keys = new TKey[] { key };
                values = new TValue[] { value };
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}