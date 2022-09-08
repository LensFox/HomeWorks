using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FluentAPI.Configuration
{
   public class DivisionConfig : EntityTypeConfiguration<Division>
    {
        public DivisionConfig()
        {
            HasKey(e => e.Id);
            Property(e => e.DivisionName).IsRequired().HasMaxLength(30).HasColumnName("Division");
            Property(e => e.DivisionHeadName).IsOptional().HasMaxLength(50);
        }
    }
}
