using System;

namespace _8_DateOfBirth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Enter your date of Birth");
            var userDateOfBirth = Console.ReadLine();
            DateTime dateOfBirth = DateTime.Parse(userDateOfBirth);
            DateTime today = DateTime.Now;
            DateTime nextBirthday = new DateTime(today.Year, dateOfBirth.Month, dateOfBirth.Day);

            if (nextBirthday < today)
            {
                var a = nextBirthday.AddYears(1);
                TimeSpan timeLeft = a - today;
                Console.WriteLine(timeLeft.Days.ToString());
            }
            else
            {
                TimeSpan timeLeft = nextBirthday - today;
                Console.WriteLine(timeLeft.Days.ToString());
            }
        }
    }
}
