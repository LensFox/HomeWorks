using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FluentAPI.Configuration
{
   public class EmployeeConfig : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfig()
        {
            HasKey(e => e.Id);
            Property(e => e.FirstName).IsRequired().HasMaxLength(50).HasColumnName("First Name");
            Property(e => e.LastName).IsRequired().HasMaxLength(50);
            Property(e => e.Position).IsRequired().HasMaxLength(40);
        }
    }
}
