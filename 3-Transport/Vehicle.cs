using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Transport
{
    internal class Vehicle
    {
        public int Speed { set; get; }
        public int Price { set; get; }
        public int ProductionYear { set; get; }
        public Vehicle(int speed, int price, int productionYear)
        {
            Speed = speed;
            Price = price;
            ProductionYear = productionYear;
        }
    }
}
