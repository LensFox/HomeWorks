using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Classroom
{
    public class Pupil
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Grades { get; set; }
        public Pupil (string surname, string name, string year, string grades)
            {
            Surname = surname;
            Name = name;
            Year = year;
            Grades = grades;
            }
        public virtual void Study()
        {
         
        }
        public virtual void Read()
        {
            Console.WriteLine("I can read");
        }
        public virtual void Write()
        {
            Console.WriteLine("I can write");
        }
        public virtual void Relax()
        {
            Console.WriteLine("I can relax");
        }
    }
}
