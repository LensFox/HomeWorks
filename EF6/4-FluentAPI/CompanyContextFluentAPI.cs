using _4_FluentAPI.Configuration;
using System;
using System.Data.Entity;
using System.Linq;

namespace _4_FluentAPI
{
    public class CompanyContextFluentAPI : DbContext
    {
        public CompanyContextFluentAPI()
            : base("name=CompanyContextFluentAPI")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CompanyContextFluentAPI>());
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new EmployeeConfig());
            modelBuilder.Configurations.Add(new DivisionConfig());
        }
    }
}