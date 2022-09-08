using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Basics_Task2
{
    public class Division
    {
        public Guid Id { get; set; }
        public string DivisionName { get; set; }
        public string DivisionHeadName { get; set; }
        public List<Employee> Employees { get; set; }
        public Division()
        {
            Employees = new List<Employee>();
        }
        public Division(string divisionName, string divisionHeadName, List<Employee> divisionEmployees)
        {
            Id = Guid.NewGuid();
            DivisionName = divisionName;
            DivisionHeadName = divisionHeadName;
            Employees = divisionEmployees;
        }
    }
}
