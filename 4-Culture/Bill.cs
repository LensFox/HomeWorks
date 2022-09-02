using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Culture
{
    internal class Bill
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public Bill(double price)
        {
            Price = price;
        }
    }
}
