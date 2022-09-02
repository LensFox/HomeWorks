using System;

namespace _1_CitizenCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            CitizenCollection<Student> students = new CitizenCollection<Student>();
            Student st1 = new Student("Pashkov", 2005, "FC7687");
            Student st2 = new Student("Murko", 2006, "KZ7877");
            Student st3 = new Student("Sinko", 2007, "HP8745");
            Student st4 = new Student("Teremkov", 2005, "CS4673");
            Student st5 = new Student("Tereshkov", 2006, "CS4673");

            students.Add(st1);
            students.Add(st2);
            students.Add(st3);
            students.Add(st4);
            students.Add(st5);

            students.Remove();

            int k;
            var c = students.ReturnLast(out k);
            Console.WriteLine(k);

            foreach (Student student in students)
                Console.WriteLine($"{student.Name}, {student.PassportNumber}, {student.YearOfBirth}");
        }
    }
}
