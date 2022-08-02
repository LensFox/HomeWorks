using System;
using System.Collections;
using System.Collections.Specialized;

namespace _2_OrderedDictionary
{
    /*
    Создайте коллекцию типа OrderedDictionary и реализуйте в ней возможность сравнения значений
ключей.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            OrderedDictionary cuteDictionary = new(new InsensitiveComparer());

            cuteDictionary.Add("gray", "szary");
            cuteDictionary.Add("yellow", "zolty");
            cuteDictionary.Add("green", "zielony");
            cuteDictionary.Add("pink", "rozowy");
            cuteDictionary.Add("red", "czerwony");
            //cuteDictionary.Add("RED", "czerwony");

            foreach (DictionaryEntry item in cuteDictionary)
                Console.WriteLine($"{item.Key} - {item.Value}");

            Console.WriteLine(cuteDictionary[0].Equals(cuteDictionary[1]));
        }
        public static bool CompareKeys(DictionaryEntry x, DictionaryEntry y)
        {
            if (x.Key == y.Key)
                return true;
            return false;
        }
    }
}
