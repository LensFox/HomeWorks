using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Houses
{
    public class House
    {
        public string address;
        public string company;
        public DateTime dateOfConstruction;
        public House(string address, string company, DateTime dateOfConstruction)
        {
            this.address = address;
            this.company = company;
            this.dateOfConstruction = dateOfConstruction;
        }
        public House()
        {

        }
        public House Clone()
        {
            House b = new House();
            b = this;
            return b;
        }
        public House DeepClone()
        {
            House b = new House();
            b.address = this.address;
            b.company = this.company;
            b.dateOfConstruction = this.dateOfConstruction;
            return b;
        }
        public static int operator - (House house, DateTime now)
        {
            TimeSpan time = now - house.dateOfConstruction;
            int a = time.Days;
            return a;
        }
        public static DateTime operator +(House house, int days)
        {
            DateTime a = house.dateOfConstruction.AddDays(days);
            return a;
        }
    }
}
