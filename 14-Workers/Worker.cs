using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Workers
{
    struct Worker
    {
        public string name;
        public string position;
        public int yearStartedWork;
        public Worker(string name, string position, int year)
        {
            this.name = name;
            this.position = position;
            yearStartedWork = year;
        }
    }
    
}
