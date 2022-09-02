using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CitizenCollection
{
    internal class Worker : Citizen
    {
        public Worker(string name, int yearOfBirth, string passportNumber)
             : base(name, yearOfBirth, passportNumber)
        {

        }
    }
}
