using System;

namespace _8_AccountantWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter the position");
            Positions position = (Positions)Enum.Parse(typeof(Positions), Console.ReadLine());
            Console.WriteLine("Enter the number of hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            bool isBonus = Accountant.AskForBonus(position, hours);
            if (isBonus == true)
                Console.WriteLine("Give him / her a bonus");
            else
                Console.WriteLine("Don't give him / her a bonus");

        }
    }
}
