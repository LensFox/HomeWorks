using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _4_BarkChange
{
    internal class Program
    {
        /*
         Задание 3
Напишите шуточную программу «Дешифратор», которая бы в текстовом файле могла бы
заменить все предлоги на слово «ГАВ!».
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FileInfo inputText = new(@"F:\Tests\TextToChange.txt");
            var stream = inputText.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            var reader = new StreamReader(stream);
            string pattern = @" в | во | для |на| без | до | за | к | ко | кроме | над | о | обо | об";

            string text = reader.ReadToEnd();
            string result = Regex.Replace(text, pattern, "ГАВ!");
            //Console.WriteLine(result);
            reader.Close();

            var stream2 = inputText.Open(FileMode.Open, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(stream2);
            writer.WriteLine(result, FileMode.Create);
            writer.Close();
        }
    }
}
