using System;

namespace _5_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article sofa = new Article("sofa", "Ikea", 3000);
            Article chair = new Article("chair", "Home&You", 400);
            Article coffeeTable = new Article("coffee table", "Ikea", 900);
            Article lamp = new Article("lamp", "Kik", 350);
            Article shelf = new Article("sofa", "Selgros", 840);

            Article[] list = new Article[] { sofa, chair, coffeeTable, lamp, shelf };

            Store poznan = new Store(list.Length, list);

            Console.WriteLine("What item are you looking for? Enter the name");

            string goalItem = Console.ReadLine();//is it possible to convert to int?

            string result = poznan[goalItem];
            if (result == null)
            {
                Console.WriteLine("We can't find the item.\nEnter the number");
                int goalNumber = Convert.ToInt32(Console.ReadLine());
                result = poznan[goalNumber];
            }
            Console.WriteLine(result);
        }
    }
}
