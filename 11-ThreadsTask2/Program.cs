using System;
using System.IO;
using System.Threading;

namespace _11_ThreadsTask2
{
    /*
     Задание 2
Создайте консольное приложение, которое в различных потоках сможет получить доступ к 2-м
файлам. Считайте из этих файлов содержимое и попытайтесь записать полученную
информацию в третий файл. Чтение/запись должны осуществляться одновременно в каждом
из дочерних потоков. Используйте блокировку потоков для того, чтобы добиться корректной
записи в конечный файл. 
     */
    internal class Program
    {
        static object block = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ReadWritePhonebook();
            Thread thread = new Thread(new ThreadStart(ReadWriteSerializationFile));
            thread.Start();

        }
        public static void ReadWriteXml(string path)
        {
            lock (block)
            {
                FileStream stream = new(path, FileMode.Open);
                var reader = new StreamReader(stream);

                const string outputPath = @"F:\Tests\ThreadsOutput.xml";
                var writer = new StreamWriter(outputPath, true);

                string input;
                while ((input = reader.ReadLine()) != null)
                {
                    writer.WriteLine(input);
                }
                writer.Close();
                reader.Close();
            }
        }
        public static void ReadWritePhonebook()
        {
            const string path = @"F:\Tests\TelephoneBook.xml";
            ReadWriteXml(path);
        }
        public static void ReadWriteSerializationFile()
        {
            const string path = @"F:\Tests\Ser.xml";
            ReadWriteXml(path);
        }
    }
}
