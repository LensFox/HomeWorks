using System;
using System.Collections;
using System.Collections.Generic;

namespace _17_EnglishPolishDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<dynamic, dynamic> dic = new Dictionary<dynamic, dynamic>();
            dic.Add("kwiatka", "flower");
            dic.Add("ksiazka", "book");
            dic.Add(80, "eighty");
            foreach (var item in dic)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

        }
    }
}
