using System;

namespace _2_Converter
{
    public class Converter
    {
        public decimal EURRate { get; set; }
        public decimal USDRate { get; set; }
        public decimal RUBRate { get; set; }

        public Converter(decimal eur, decimal usd, decimal rub)
        {
            EURRate = eur;
            USDRate = usd;
            RUBRate = rub;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which currency would you like to convert? Enter UAH, USD, EUR or RUB");
            string inputCurrencyType = Console.ReadLine();
            Console.WriteLine($"How much {inputCurrencyType} have you got?");
            decimal amountOfMoney = Convert.ToDecimal(Console.ReadLine());
            Converter Rate = new Converter(35, 30, 0.35m);
            switch (inputCurrencyType)
            {
                case "UAH":
                    Console.WriteLine("Which currency would you like to receive? Enter USD, EUR or RUB");
                    string outputCurrencyType = Console.ReadLine();
                    if (outputCurrencyType == "USD")
                    {
                        Console.WriteLine($"You will receive {amountOfMoney / Rate.USDRate} dollars");
                    }
                    else if (outputCurrencyType == "EUR")
                    {
                        Console.WriteLine($"You will receive {amountOfMoney / Rate.EURRate} euros");
                    }
                    else if (outputCurrencyType == "RUB")
                    {
                        Console.WriteLine($"You will receive {amountOfMoney / Rate.RUBRate} rubles");
                    }
                    else
                    {
                        Console.WriteLine("Invalid currency");
                    }
                    break;
                case "EUR":
                    Console.WriteLine($"You will receive {amountOfMoney * Rate.EURRate} hryvnyas");
                    break;
                case "USD":
                    Console.WriteLine($"You will receive {amountOfMoney * Rate.USDRate} hryvnyas");
                    break;
                case "RUB":
                    Console.WriteLine($"You will receive {amountOfMoney * Rate.RUBRate} hryvnyas");
                    break;
                default:
                    Console.WriteLine("Convertation of this currency is unavailable");
                    break;

            }

        }
    }
}
