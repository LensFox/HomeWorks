using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _4_FindInfo
{
    /*
     Задание 2
Напишите программу, которая бы позволила вам по указанному адресу web-страницы
выбирать все ссылки на другие страницы, номера телефонов, почтовые адреса и сохраняла
полученный результат в файл.  
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var phoneNumberPattern = new Regex(@"\+[0-9]{11,12}");
            var emailPattern = new Regex(@"^[a-z0-9_-]+@[a-z]+\.([a-z]{2,3})+$");
            var webpagePattern = new Regex(@"^(https:\/\/)(www\.)*[a-z0-9\._\-?/]+$");
            //var webpagePattern = new Regex(@"/(http(s)?://)?([\w-]+\.)+[\w-]+[.com]+(/[/?%&=]*)?/");

            var infoFile = new FileInfo(@"F:\Tests\Info.txt");
            FileStream stream = infoFile.Create();
            //infoFile.OpenWrite();
            StreamWriter writer = new StreamWriter(stream);

            var sourceFile = new FileInfo(@"F:\Tests\LotsOfInformation.txt");
            FileStream stream1 = sourceFile.OpenRead();
            StreamReader reader = new(stream1);

            string input;
            while ((input = reader.ReadLine()) != null)
            {
                if (phoneNumberPattern.IsMatch(input))
                    writer.WriteLine(input);
            }
            writer.Close();
        }
    }
}
