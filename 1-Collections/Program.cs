using System;

namespace _1_Collections
{
    /*
Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и
количество дней в соответствующем месяце. Реализуйте возможность выбора месяцев, как по
порядковому номеру, так и количеству дней в месяце, при этом результатом может быть не
только один месяц.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Month jan = new Month("January", 31, 1);
            Month may = new Month("May", 31, 5);
            Month sep = new Month("September", 30, 9);

            MonthsCollection<Month> year = new();
            year.Add(jan);
            year.Add(may);
            year.Add(sep);

            foreach (Month month in year)
                Console.WriteLine($"{month.Name}, {month.DaysInMonth}, {month.OrderNumber}");

            Console.WriteLine($"Contains May? {year.Contains(may)}");

            year.Remove(may);

            Console.WriteLine($"Contains May? {year.Contains(may)}");

            foreach (Month month in year)
                Console.WriteLine($"{month.Name}, {month.DaysInMonth}, {month.OrderNumber}");


        }
    }

}

