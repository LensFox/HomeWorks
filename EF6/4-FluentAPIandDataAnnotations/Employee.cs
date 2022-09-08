using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FluentAPIandDataAnnotations
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(30)]
        public string Position { get; set; }

        public Employee()
        {
        }
        public Employee(string firstName, string lastName, string position)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }
    }
}
