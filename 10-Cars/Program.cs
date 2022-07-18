using System;

namespace _10_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car one = new Car(2004, "Dodge");
            Car two = new Car(2008, "Zhyguli");

            CarCollection<Car> cool = new CarCollection<Car> (one, two);

            Bus bus = new Bus(2000, "Mercedes");

            cool.Add(bus);

            Console.WriteLine(cool.Count);
        }
    }
}
