using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Transport
{
    internal class Ship : Vehicle
    {
        public int NumberOfPassengers { get; set; }
        public string Port { set; get; }
        public Ship(int speed, int price, int productionYear, int numberOfPassengers, string port)
            : base(speed, price, productionYear)
        {
            NumberOfPassengers = numberOfPassengers;
            Port = port;
        }
        public void Show()
        {
            Console.WriteLine($"Means of travelling: Ship\n" +
                $"Speed: {Speed}\n" +
                $"Price: {Price}\n" +
                $"Year of production: {ProductionYear}\n" +
                $"Number of passengers: {NumberOfPassengers}\n" +
                $"Port:{Port}\n");
        }
    }
}
