using System;

namespace _16_Houses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            House house1 = new House("aa", "bb", DateTime.Parse("26 / 09 / 1998"));
            House house2 = new House("xx", "yy", DateTime.Parse("29 / 01 / 1970"));

            Console.WriteLine($"House 1. Address: {house1.address}, Company: {house1.company}," +
                $" Date: {house1.dateOfConstruction}");
            Console.WriteLine($"House 2. Address: {house2.address}, Company: {house2.company}," +
                $" Date: {house2.dateOfConstruction}");

            House house3 = new House();
            house3 = house1.Clone();
            Console.WriteLine($"House 3. Address: {house3.address}, Company: {house3.company}," +
                $" Date: {house3.dateOfConstruction}");

            house3.dateOfConstruction = DateTime.Parse("03.04.1976");
            Console.WriteLine($"House 1. Address: {house1.address}, Company: {house1.company}," +
                $" Date: {house1.dateOfConstruction}");
            Console.WriteLine($"House 3. Address: {house3.address}, Company: {house3.company}," +
                $" Date: {house3.dateOfConstruction}");

            House house4 = new House();
            house4 = house2.DeepClone();

            Console.WriteLine($"House 4. Address: {house4.address}, Company: {house4.company}," +
               $" Date: {house4.dateOfConstruction}");

            house4.dateOfConstruction = DateTime.Parse("11.08.2007");

            Console.WriteLine($"House 2. Address: {house2.address}, Company: {house2.company}," +
                $" Date: {house2.dateOfConstruction}");
            Console.WriteLine($"House 4. Address: {house4.address}, Company: {house4.company}," +
               $" Date: {house4.dateOfConstruction}");

            DateTime now = DateTime.Now;
            Console.WriteLine(house2 - now);

            Console.WriteLine(house2 + 66);
        }
    }
}
