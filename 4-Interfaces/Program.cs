using System;

namespace _4_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What do you want to do?\n" +
                "1 - Play\n2 - Record\n3 - Pause\n4 - Stop");
            string userInstruction = Console.ReadLine();
            Player song = new Player();
            if (userInstruction == "1")
            {
                song.Play();
            }
            else if (userInstruction == "2")
            {
                song.Record();
            }
            else if (userInstruction == "3")
            {
                song.Pause();
            }
            else if (userInstruction == "4")
            {
                song.Stop();
            }
            else
            {
                Console.WriteLine("Incorrect instruction");
            }
        }
    }
}
