using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_AutoShop
{
    public class Auto
    {
        public string brand;
        public string model;
        public int year;
        public string colour;
        public Auto(string brand, string model, int year, string colour)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.colour = colour;
        }
    }
}
