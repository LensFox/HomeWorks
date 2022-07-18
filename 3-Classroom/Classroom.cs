using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Classroom
{
    internal class Classroom
    {
        public Pupil A { set; get; }
        public Pupil B { set; get; }
        public Pupil C { set; get; }
        public Pupil D { set; get; }

        public Classroom (Pupil a, Pupil b, Pupil c, Pupil d)
        {
            A = a;
            B = b;
            C = c;
            D = d; 
        }

        public Classroom(Pupil a, Pupil b, Pupil c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Classroom(Pupil a, Pupil b)
        {
            A = a;
            B = b;
        }
    }
}
