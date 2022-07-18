using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Transport
{
    internal class Plane : Vehicle
    {
        public int NumberOfPassengers { set; get; }
        public int Height { set; get; }

        public Plane(int speed, int price, int productionYear, int numberOfPassengers, int height)
            : base(speed, price, productionYear)
        {
            NumberOfPassengers = numberOfPassengers;
            Height = height;
        }
        public void Show()
        {
            Console.WriteLine($"Means of travelling: Plane\n" +
                $"Speed: {Speed}\n" +
                $"Price: {Price}\n" +
                $"Year of production: {ProductionYear}\n" +
                $"Number of passengers: {NumberOfPassengers}\n" +
                $"Height:{Height}\n");
        }
    }
}
