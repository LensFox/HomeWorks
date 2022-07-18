using System;

namespace _3_Classroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BadPupil Ivanov = new BadPupil("Ivanov", "Gleb", "5", "2");
            ExcellentPupil Petrov = new ExcellentPupil("Petrov", "Ivan", "5", "5");
            GoodPupil Shyshkin = new GoodPupil("Shyshkin", "Aleksey", "5", "4");

            Classroom year5 = new Classroom(Ivanov, Petrov, Shyshkin);

            Console.WriteLine("Enter the pupil's surname");
            string surname = Console.ReadLine();

            if (surname == year5.A.Surname) //rewrite switch -> if
            {
                year5.A.Study();
                year5.A.Write();
                year5.A.Read();
                year5.A.Relax();
            }
            else if (surname == year5.B.Surname)
            {
                year5.B.Study();
                year5.B.Write();
                year5.B.Read();
                year5.B.Relax();
            }
            else if (surname == year5.C.Surname)
            {
                year5.C.Study();
                year5.C.Write();
                year5.C.Read();
                year5.C.Relax();
            }
            else
            {
                Console.WriteLine("The pupil doesn't exist in this class");
            }

        }


    }
}
}
