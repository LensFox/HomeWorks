using System;

namespace _2_Salary
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname;
        public string Position;
        public decimal Experience;
        public const decimal TaxRate = 0.27m;
        public decimal Salary;
        public decimal SalaryMinusTax;

        public Employee(string name, string surname, string position, decimal experience)
        {
            Name = name;
            Surname = surname;
            Position = position;
            Experience = experience;
        }

        public void SalaryAndTaxCalculator(decimal experience, string position)
        {
            decimal tax;
            decimal juniorSalary = 1000;
            decimal middleSalary = 1500;
            decimal seniorSalary = 2000;
            decimal coefficientFrom2to5years = 1.1m;
            decimal coefficientFrom6to9years = 1.2m;
            decimal coefficient10andMore = 1.3m;
            if (position == "Junior")
            {
                if (experience < 2)
                {
                    Salary = juniorSalary;
                    //tax = Salary * TaxRate;
                    //SalaryMinusTax = Salary - tax;
                }
                else if (experience > 1 && experience < 6)
                {
                    Salary = juniorSalary * coefficientFrom2to5years;
                    
                }
                else if (experience > 5 && experience < 10)
                {
                    Salary = juniorSalary * coefficientFrom6to9years;
                }
                else if (experience > 9)
                {
                    Salary = juniorSalary * coefficient10andMore;
                }
                else
                {
                    Console.WriteLine("Invalid data!");
                }
            }
            else if (position == "Middle")
            {
                if (experience < 2)
                {
                    Salary = middleSalary;
                }
                else if (experience > 1 && experience < 6)
                {
                    Salary = middleSalary * coefficientFrom2to5years;
                }
                else if (experience > 5 && experience < 10)
                {
                    Salary = middleSalary * coefficientFrom6to9years;
                }
                else if (experience > 9)
                {
                    Salary = middleSalary * coefficient10andMore;
                }
                else
                {
                    Console.WriteLine("Invalid data!");
                }

            }
            else if (position == "Senior")
                if (experience < 2)
                {
                    Salary = seniorSalary;
                }
                else if (experience > 1 && experience < 6)
                {
                    Salary = seniorSalary * coefficientFrom2to5years;
                }
                else if (experience > 5 && experience < 10)
                {
                    Salary = seniorSalary * coefficientFrom6to9years;
                }
                else if (experience > 9)
                {
                    Salary = seniorSalary * coefficient10andMore;
                }
                else
                {
                    Console.WriteLine("Invalid data!");
                }
            else
            {
                Console.WriteLine("Invalid data!");
            }
            tax = Salary * TaxRate;
            SalaryMinusTax = Salary - tax;
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name} {Surname}\n" +
                $"Position: {Position}\n" +
                $"Expirience: {Experience}\n" +
                $"Salary with coefficient: {Salary}\n" +
                $"Salary with coefficient minus tax: {SalaryMinusTax}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee petrovAI = new Employee("Petrov", "Alexandr", "Junior", 5);
            Employee IvanovMS = new Employee("Ivanov", "Mikhail", "Senior", 13);
            Employee SokolovaTP = new Employee("Sokolova", "Tatiana", "Middle", 1);
            Console.WriteLine("Enter the employee's surname");
            string surname = Console.ReadLine();
            switch (surname)
            {

                case "Petrov":
                    {
                        petrovAI.SalaryAndTaxCalculator(petrovAI.Experience, petrovAI.Position);
                        petrovAI.Show();
                        break;
                    }
                case "Ivanov":
                    {
                        IvanovMS.SalaryAndTaxCalculator(IvanovMS.Experience, IvanovMS.Position);
                        IvanovMS.Show();
                        break;
                    }
                case "Sokolova":
                    {
                        SokolovaTP.SalaryAndTaxCalculator(SokolovaTP.Experience, SokolovaTP.Position);
                        SokolovaTP.Show();
                        break;
                    }
                default:
                    Console.WriteLine("The employee doesn't exist!");
                    break;
            }
        }
    }
}
