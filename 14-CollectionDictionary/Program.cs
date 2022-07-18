using System;

namespace _14_CollectionDictionary
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            MyDictionary<string, string> dict = new MyDictionary<string, string>("apple", "jablko");
            dict.Add("water", "woda");
            Console.WriteLine(dict["water"]);
            dict.Add("bun", "bulka");
            Console.WriteLine(dict["bun"]);
            Console.WriteLine(dict.Count);
            var dict2 = new MyDictionary<bool, int>();
            dict2.Add(true, 1);
            Console.WriteLine(dict2[true]);
            foreach (var item in dict)
                Console.WriteLine(item);
        }
    }
}
