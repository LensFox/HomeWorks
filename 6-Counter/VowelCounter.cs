using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Counter
{
    internal static class VowelCounter
    {
        static string[] vowels = new string[] { "a", "e", "i", "o", "u", "y" };
        public static void Count(this string text)
        {
            text.ToLower();
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < vowels.Length; j++)
                    if (text.Substring(i, 1) == vowels[j])
                        counter++;
            Console.WriteLine($"In the text there are {counter} vowels");
        }
    }
}
