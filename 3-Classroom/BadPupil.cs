using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Classroom
{
    public class BadPupil : Pupil
    {
        public BadPupil(string surname, string name, string year, string grades)
            : base (surname, name, year, grades)
        {

        }
        public override void Study()
        {
            Console.WriteLine("I can't study");
        }
        public override void Read()
        {
            Console.WriteLine("I can read badly");
        }
        public override void Write()
        {
            Console.WriteLine("I can write badly");
        }
        public override void Relax()
        {
            Console.WriteLine("I can relax perfectly well");
        }
    }
}
