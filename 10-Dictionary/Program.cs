using System;

namespace _10_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDictionary<string,string> dictionary = new MyDictionary<string, string>(10);
            dictionary.keys[0] = "table";
            dictionary.keys[1] = "book";
            dictionary.keys[2] = "apple";
            dictionary.values[0] = "стол";
            dictionary.values[1] = "книга";
            dictionary.values[2] = "яблоко";

            dictionary.Add("laptop", "ноутбук");

            Console.WriteLine(dictionary.numberOfPairsOfElements);

            Console.WriteLine(dictionary[1]);
                }
    }
}
