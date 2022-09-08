using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FluentAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new CompanyContextFluentAPI())
            {
                var employee1 = new Employee("Olena", "Ivankova", "Special Mentee");
                var employee2 = new Employee("Ivan", "Petrov", ".Net developer");
                var employee3 = new Employee("Tatyana", "Sokolova", "Division Manager");
                var employee4 = new Employee("Roman", "Romanchenko", "Team lead");
                var employee5 = new Employee("Petr", "Petrov", "Jr JS developer");

                context.Employees.AddRange(new List<Employee>
                { employee1, employee2, employee3, employee4, employee5 }
                );
                context.SaveChanges();

                var NetDivision = new Division(".Net", "Konstantin Rubanov", new List<Employee> { employee1, employee3, employee4 });
                var JSDivision = new Division("JavaScript", "Dmitriy Slepenkov", new List<Employee> { employee2, employee5 });
                context.Divisions.AddRange(new List<Division> { NetDivision, JSDivision });
                context.SaveChanges();
                var query = from p in context.Employees
                            where p.FirstName == "Olena"
                            select p;
                foreach(var item in query)
                {
                    Console.WriteLine(item.LastName);
                }
            }
            Console.ReadKey();
        }
    }
}
