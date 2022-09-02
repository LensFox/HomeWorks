using System;
using System.IO;
using System.IO.Compression;

namespace _3_Files
{/*
  Задание 2
Создайте файл, запишите в него произвольные данные и закройте файл. Затем снова откройте
этот файл, прочитайте из него данные и выведете их на консоль.

  Задание 3
Напишите приложение для поиска заданного файла на диске. Добавьте код, использующий
класс FileStream и позволяющий просматривать файл в текстовом окне. В заключение
добавьте возможность сжатия найденного файла.
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var file = new FileInfo(@"F:\Tests\Text.txt");
            FileStream fileStream = file.Create();
            fileStream.Close();

            StreamWriter writer = file.CreateText();
            writer.WriteLine("This is my text");
            writer.Write(writer.NewLine);
            writer.WriteLine("Smile!");
            writer.Close();

            StreamReader reader = File.OpenText(@"F:\Tests\Text.txt");
            string input;
            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            reader.Close();


            //search
            string[] filesPaths = Directory.GetFiles(@"F:\Tests", "Text.txt");

            //Добавьте код, использующий класс FileStream
            //и позволяющий просматривать файл в текстовом окне. ???

            //compression
            FileStream source = File.OpenRead(filesPaths[0]);
            FileStream destination = File.Create(@"F:\Tests\archive.zip");

            GZipStream compressor = new(destination, CompressionMode.Compress);

            int theByte= source.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }
            compressor.Close();
        }
    }
}
