using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Dictionary
{
    public class MyDictionary<TKey, TValue>
    {
        public TKey[] keys;
        public TValue[] values;
        public int numberOfPairsOfElements
        {
            get
            {
                return keys.Length;
            }
        }
        public MyDictionary(int numberOfElements)
        {
            keys = new TKey[numberOfElements];
            values = new TValue[numberOfElements];
        }
        public string this[int index]
        {
            get
            {
                return String.Format($"{keys[index]}  - {values[index]}");
            }
        }
        public (TKey[], TValue[]) Add(TKey key, TValue value)
        {
            int length = keys.Length + 1;
            TKey[] biggerKeys = new TKey[length];
            for (int i = 0; i < keys.Length; i++)
            {
                biggerKeys[i] = keys[i];
            }
            biggerKeys[length - 1] = key;
            keys = biggerKeys;

            length = values.Length + 1;
            TValue[] biggerValues = new TValue[length];

            for (int i = 0; i < values.Length; i++)
            {
                biggerValues[i] = values[i];
            }
            biggerValues[length - 1] = value;
            values = biggerValues;
            return (keys, values);
        }
    }
}
