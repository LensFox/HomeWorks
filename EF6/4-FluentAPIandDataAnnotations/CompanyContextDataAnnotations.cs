using System;
using System.Data.Entity;
using System.Linq;

namespace _4_FluentAPIandDataAnnotations
{
    public class CompanyContextDataAnnotations : DbContext
    {
       
        public CompanyContextDataAnnotations()
            : base("name=CompanyContextDataAnnotations")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CompanyContextDataAnnotations>());
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
    }
}