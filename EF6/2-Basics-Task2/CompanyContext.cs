using System;
using System.Data.Entity;
using System.Linq;

namespace _2_Basics_Task2
{
    public class CompanyContext : DbContext
    {
        
        public CompanyContext()
            : base("name=CompanyContext")
        {
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }

    }
}