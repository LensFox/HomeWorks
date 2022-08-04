using System;
using System.IO;

namespace _3_HundredDirectories
{/*
  Дополнительное задание
  Создайте на диске 100 директорий с именами от Folder_0 до Folder_99, затем удалите их. 
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var directory = new DirectoryInfo(@"F:\Tests");

            for (int i = 1; i <= 10; i++)
            {
                directory.CreateSubdirectory($"NewDirectory{i}");
                Console.WriteLine($"NewDirectory{i} was created");
            }

            Console.WriteLine("\nPress any key to delete\n");
            Console.ReadKey();

            //directory.Delete(true);

            for (int i = 1; i <= 10; i++)
            {
                Directory.Delete($@"F:\Tests\NewDirectory{i}");
                Console.WriteLine($"NewDirectory{i} was deleted");
            }
        }
    }
}
