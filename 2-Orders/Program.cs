using System;

namespace _2_Orders
{
    public class Invoice
    {
        public int Account { get; } // if I don't write neither set; or get;? Isn't readonly the same?
        public string Customer { get; }
        public string Provider = "OurCompany";
        public readonly string Article;
        public readonly int Quantity;
        public double TotalSum;
        public double TotalSumMinusVAT;
        public Invoice(int account, string customer, string article, int quantity)
        {
            Account = account;
            Customer = customer;
            Article = article;
            Quantity = quantity;
        }
        public void VATCalculator(int price)
        {
            const int VAT = 20;
            TotalSum = Quantity * price;
            double a = TotalSum / 100;
            double b = a * VAT;
            TotalSumMinusVAT = TotalSum - b;
        }
        public void Show()
        {
            Console.WriteLine($"Account: {Account}\n" +
                            $"Customer: {Customer}\n" +
                            $"Provider: {Provider}\n" +
                            $"Article: {Article}\n" +
                            $"Quantity: {Quantity}\n" +
                            $"Total: {TotalSum}\n" +
                            $"Total with VAT: {TotalSumMinusVAT}");
            Console.WriteLine("-", 50);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int bananaPrice = 5;
            int orangePrice = 3;
            int kiwiPrice = 4;
            int i = 1;
        Label:
            Console.WriteLine("What would you like to buy?");
            string article = Console.ReadLine();
            Console.WriteLine("Enter the quantity (kg)");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the customer's name");
            string customer = Console.ReadLine();

            switch (article)
            {
                case "banana":
                    {
                        Invoice Bananas = new Invoice(i, customer, article, quantity);
                        Bananas.VATCalculator(bananaPrice);
                        Bananas.Show();
                        i++;
                        goto Label;
                        
                    }
                case "orange":
                    {
                        Invoice Oranges = new Invoice(i, customer, article, quantity);
                        Oranges.VATCalculator(orangePrice);
                        Oranges.Show();
                        i++;
                        goto Label;
                    }
                case "kiwi":
                    {
                        Invoice Kiwis = new Invoice(i, customer, article, quantity);
                        Kiwis.VATCalculator(kiwiPrice);
                        Kiwis.Show();
                        i++;
                        goto Label;
                    }
                default:
                    {
                        Console.WriteLine("This item isn't available :(");
                        break;
                    }

            }


        }
    }
}
