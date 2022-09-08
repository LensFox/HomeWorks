using _2_Basics_Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace _4_FluentAPIandDataAnnotations
{
    //DataAnnotations
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CompanyContextDataAnnotations())
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

                var employees = context.Employees.ToList();
                foreach (var item in employees)
                {
                    Console.WriteLine("{0}) {1} {2} - {3}", item.Id, item.FirstName, item.LastName, item.Position);
                }

                var divisions = context.Divisions.ToList();
                foreach (var item in divisions)
                {
                    Console.WriteLine("{0}) {1} {2}", item.Id, item.DivisionName, item.DivisionHeadName);
                    if (item.Employees.Any())
                    {
                        foreach (var employee in item.Employees)
                        {
                            Console.WriteLine("{0}) {1} {2} - {3}",
                                employee.Id, employee.FirstName, employee.LastName, employee.Position);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
