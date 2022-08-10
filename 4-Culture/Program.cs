using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace _4_Culture
{
    /*
     Задание 4
Создайте текстовый файл-чек по типу «Наименование товара – 0.00 (цена) грн.» с
определенным количеством наименований товаров и датой совершения покупки. Выведите на
экран информацию из чека в формате текущей локали пользователя и в формате локали enUS. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var file = new FileInfo(@"F:\Tests\Bill.txt");
            FileStream stream = file.Open(FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(stream);

            List<Bill> billList = new();
            string input = reader.ReadLine();
            while ((input = reader.ReadLine()) != "")
            {
                Match price = Regex.Match(input, @"(\d){2,4}?\.(\d){2}");
                Match name = Regex.Match(input, @"^[a-z ]+");
                Match date = Regex.Match(input, @"(\d){2}/(\d){2}/(\d){2,4}$");

                var p = price.Captures[0].ToString();
                var pd = double.Parse(p, CultureInfo.InvariantCulture);
                billList.Add(new Bill(pd));

                var n = name.Captures[0].ToString();
                billList[^1].Name = n;

                var d = date.Captures[0].ToString();
                DateTime dat = DateTime.Parse(d);
                billList[^1].Date = dat;
            }
            reader.Close();

            var be = new CultureInfo("be-BY");
            var am = new CultureInfo("en-US");
            var cur = CultureInfo.CurrentCulture;

            ShowBillWithCulture(billList, be);
            Console.WriteLine();
            ShowBillWithCulture(billList, am);
            Console.WriteLine();
            ShowBillWithCulture(billList, cur);
        }
        public static void ShowBillWithCulture(List<Bill> list, CultureInfo culture)
        {
            foreach (Bill item in list)
            {
                Console.WriteLine();
                Console.Write($"Item: {item.Name}  ");
                var pr = item.Price.ToString("C", culture);
                Console.Write("Price: {0:C}  ",pr);
                var date = item.Date.Date.ToString(culture);
                Console.Write("Date: {0}", date);
            }
        }
    }
}
