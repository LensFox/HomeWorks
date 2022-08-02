using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Collections
{
    public class Month
    {
        public string Name { get; set; }
        internal int DaysInMonth { get; set; }
        internal int OrderNumber { get; set; }
        public Month(string name, int daysInMonth, int orderMonth)
        {
            Name = name;
            DaysInMonth = daysInMonth;
            OrderNumber = orderMonth;
        }
    }
}
