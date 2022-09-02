using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace _2_BankAccounts
{
    /*
  Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и
  вещественные значения, по типу «счет предприятия – доступная сумма» соответственно.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //task 1

            Dictionary<ulong, decimal> accountBalance = new();

            accountBalance.Add(658575859875, 2394654);
            accountBalance.Add(946200947456, -20876);
            accountBalance.Add(850064008641, 98650);
            accountBalance.Add(657652009876, 7600);
            accountBalance.Add(980064053108, -3800);

            Console.WriteLine(accountBalance[946200947456]);

            SortedList<ulong, decimal> accountBalance2 = new();

            accountBalance2.Add(658575859875, 2394654);
            accountBalance2.Add(946200947456, -20876);
            accountBalance2.Add(850064008641, 98650);
            accountBalance2.Add(657652009876, 7600);
            accountBalance2.Add(980064053108, -3800);

            Console.WriteLine(accountBalance[946200947456]);

            
        }
    }
}
