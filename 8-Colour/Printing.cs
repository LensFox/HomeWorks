using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Colour
{
    public static class Printing
    {
        public static void Print(string text, Colours colour)
        {
            switch (colour)
            {
                case Colours.yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Colours.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Colours.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Colours.blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Colours.purple:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                    case Colours.pink:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.WriteLine("Sorry, we don't support this colour");
                    break;
            }
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
