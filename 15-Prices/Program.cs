using System;
using System.Linq;

namespace _15_Prices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Price[] prices = new Price[2];
            Price sofa = new Price("sofa Blabla", "IKEA", 350);
            prices[0] = sofa;
            Console.WriteLine("Enter the item name");
            string newItemName = Console.ReadLine();
            Console.WriteLine("Enter the shop");
            string newItemShop = Console.ReadLine();
            Console.WriteLine("Enter the item price");
            string newItemPrice = Console.ReadLine();
            try
            {
                int newItemPriceInt = int.Parse(newItemPrice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            prices = prices.ToList().OrderBy
               (x => x.shopName).ToArray();

            Console.WriteLine("Enter the shop name you'd like to see");
            string goalShop = Console.ReadLine();

            try
            {
                if (prices.Where(x => x.shopName == goalShop).FirstOrDefault().shopName == null)
                    throw new Exception("smth");
                else
                {
                    for (int i = 0; i < prices.Length; i++)
                    {
                        if (prices[i].shopName == goalShop)
                        {
                            Console.WriteLine($"Item: {0}, Price {1}", prices[i].itemName, prices[i].itemName);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
