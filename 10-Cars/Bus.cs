using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cars
{
    public class Bus : Car
    {
        public Bus(int year, string name) : base(year, name)
        {
            this.year = year;
            this.carName = name;
        }
    }
}
