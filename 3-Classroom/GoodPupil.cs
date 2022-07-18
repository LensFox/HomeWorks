using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Classroom
{
    internal class GoodPupil:Pupil
    {
        public GoodPupil(string surname, string name, string year, string grades)
           : base(surname, name, year, grades)
        {

        }
        public override void Study()
        {
            Console.WriteLine("I can study well");
        }
        public override void Read()
        {
            Console.WriteLine("I can read well");
        }
        public override void Write()
        {
            Console.WriteLine("I can write well");
        }
        public override void Relax()
        {
            Console.WriteLine("I can relax well");
        }
    }
}
