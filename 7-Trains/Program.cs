using System;
using System.Linq;

namespace _7_Trains
{
    struct Train
    {
        public string destination;
        public int trainNumber;
        public string time;
        public Train(string destination, int trainNumber, string time)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.time = time;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Train[] timetable = new Train[8];
            for (int i = 0; i < timetable.Length; i++)
            {
                Console.WriteLine("Enter the destination");
                timetable[i].destination = Console.ReadLine();
                Console.WriteLine("Enter the train number");
                timetable[i].trainNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the time and date starting with year, month.. (use commas)");
                timetable[i].time = Console.ReadLine();
            }
            var sortedTimetable = timetable.ToList().OrderBy(x => x.trainNumber).ToArray();
            Console.Write("Enter the train number:");
            int targetTrainNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sortedTimetable.Length; i++)
            {
                if (sortedTimetable[i].trainNumber == targetTrainNumber)
                {
                    Console.WriteLine($"Destination: {sortedTimetable[i].destination}\n" +
                        $"Train number: {sortedTimetable[i].trainNumber}\n" +
                        $"Date and time: {sortedTimetable[i].time}");
                }
                else
                    Console.WriteLine("Not Found :(");
            }
        }
    }
}
