using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FluentAPIandDataAnnotations
{
    [Table("Divisions")]
    public class Division
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(30)]
        public string DivisionName { get; set; }
        [Required, MaxLength(50)]
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
