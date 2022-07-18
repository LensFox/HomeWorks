using System;

namespace _5_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary englishRussianUkrainianDictionary = new Dictionary();
            Console.WriteLine("Hello! Enter the word");
            string word = Console.ReadLine();
            Console.WriteLine(englishRussianUkrainianDictionary[word]);
        }
    }
}
