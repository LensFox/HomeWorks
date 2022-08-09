using System;
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

            var am = new CultureInfo("en-US");

            string input = reader.ReadLine();
            //while ((input = reader.ReadLine()) != null)
            //{
            //    Console.WriteLine(input.ToString(CultureInfo.CurrentCulture));
            //}
            //stream.Position = 0;

            while ((input = reader.ReadLine()) != null)
            {
                Match price = Regex.Match(input, @"(\d){2,5}\.(\d){2}");
                foreach (var item in price.Groups)
                {
                    item.ToString();
                    var s = Convert.ToDouble(item);
                    Console.WriteLine(s.ToString(am));
                }
                //Console.WriteLine(input.ToString(am));
            }
            reader.Close();


        }
    }
}
