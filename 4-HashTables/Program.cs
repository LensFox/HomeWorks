using System;
using System.Collections;

namespace _4_HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ourClass = new Hashtable();

            ourClass.Add("Kolya", "Sidorov");
            ourClass.Add("Anya", "Belik");
            ourClass.Add("Misha", "Shishkin");
            ourClass.Add("Tanya", "Pushkina");

            Console.WriteLine($"Number of students:{ourClass.Count}");
            foreach (DictionaryEntry student in ourClass)
            {
                Console.WriteLine($"Name: {student.Key}, Last name: {student.Value}");
            }
           
        }
    }
}
