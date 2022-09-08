using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FluentAPI
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public Employee()
        {
        }
        public Employee(string firstName, string lastName, string position)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }
    }
}
