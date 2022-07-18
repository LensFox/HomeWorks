using System;

namespace _8_Colour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Hello! Enter your message:");
                string text = Console.ReadLine();
                Console.WriteLine("Choose the colour.\n1 - yellow\n2 - red\n3 - green\n4 - blue\n5 - purple\n6 - pink");
                Colours colour = (Colours)Enum.Parse(typeof(Colours),Console.ReadLine());
                Console.WriteLine(typeof(Colours));
                Printing.Print(text, colour);
            }
        }
    }
}
