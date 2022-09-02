using System;
using System.Collections.Generic;

namespace _2_SystemCollections
{
    /*
     Используя класс SortedList, создайте небольшую коллекцию и выведите на экран значения пар
«ключ- значение» сначала в алфавитном порядке, а затем в обратном.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var descendingComparer = Comparer<string>.Create((x, y) => y.CompareTo(x));

            SortedList<string, string> prettyDictionary = new();    //alphabetical order
            //SortedList<string, string> prettyDictionary = new(descendingComparer);    //reverse order

            prettyDictionary.Add("gray", "szary");
            prettyDictionary.Add("yellow", "zolty");
            prettyDictionary.Add("green", "zielony");
            prettyDictionary.Add("pink", "rozowy");
            prettyDictionary.Add("red", "czerwony");

            foreach (KeyValuePair<string, string> item in prettyDictionary) 
                Console.WriteLine($"{item.Key} - {item.Value}");

        }
    }
}
