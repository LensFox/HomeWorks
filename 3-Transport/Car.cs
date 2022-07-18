using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Transport
{
    internal class Car : Vehicle
    {
        public Car(int speed, int price, int productionYear)
        : base(speed, price, productionYear)
        {
        }
        public void Show()
        {
            Console.WriteLine($"Means of travelling: Car\n" +
                $"Speed: {Speed}\n" +
                $"Price: {Price}\n" +
                $"Year of production: {ProductionYear}\n");
        }
    }
}
