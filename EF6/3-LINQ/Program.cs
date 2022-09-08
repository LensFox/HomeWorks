using _2_Basics_Task1;
using _2_Basics_Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StaffContext())
            {
                var first = context.Employees.FirstOrDefault(e => e.FirstName == "Olena");
                Console.WriteLine("{0} {1} - {2}", first.FirstName, first.LastName, first.Position);
                Console.WriteLine(new string('-', 30));

                var firstOrDefault = context.Employees.Where(e => e.FirstName == "Roman").FirstOrDefault();
                Console.WriteLine("{0} {1} - {2}", firstOrDefault.FirstName, firstOrDefault.LastName, firstOrDefault.Position);
                Console.WriteLine(new string('-',30));

                var orderedList = context.Employees.Select(e => e).OrderBy(e => e.LastName);
                foreach (var emp in orderedList)
                    Console.WriteLine("{0} {1} - {2}", emp.FirstName, emp.LastName, emp.Position);
                Console.WriteLine(new string('-', 30));
                 
                int count = context.Employees.Count(e=> e.Position.Contains(".Net"));

                int min = context.Divisions.Min(d=> d.Employees.Count);

                int max = context.Divisions.Max(d => d.Employees.Count);

                var include = context.Divisions.Include("Employees"); //e => e.Employee???
                foreach (var div in include)
                {
                    Console.WriteLine("{0}, {1}", div.DivisionName, div.DivisionHeadName);
                    foreach(var emp in div.Employees)
                    {
                        Console.WriteLine("{0} {1} - {2}", emp.FirstName, emp.LastName, emp.Position);
                    }
                    Console.WriteLine(new string('-', 5));
                }

                var select = context.Divisions.Select(d => new { d.DivisionName, d.Employees })
                    .Where(d => d.DivisionName=="Java Script");
                foreach (var div in select)
                {
                    Console.WriteLine(div.DivisionName);
                    foreach (var emp in div.Employees)
                    {
                        Console.WriteLine("{0} {1} - {2}", emp.FirstName, emp.LastName, emp.Position);
                    }
                    Console.WriteLine(new string('-', 5));
                }

                //var find = context.Employees.Find(618d7b49-2917-4ce8-92b3-c5fc6bc3c4ab);
            }
            using (var context = new CompanyContext())
            {
                var orderedList = from e in context.Employees
                                  orderby e.Position
                                  select e;
                foreach (var emp in orderedList)
                    Console.WriteLine("{0} {1} - {2}", emp.FirstName, emp.LastName, emp.Position);
            }
            Console.ReadKey();
        }
    }
}
