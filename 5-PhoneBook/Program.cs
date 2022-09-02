using System;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace _5_PhoneBook
{
    /*
     Создайте .xml файл, который соответствовал бы следующим требованиям:
   имя файла: TelephoneBook.xml
   корневой элемент: “MyContacts”
   тег “Contact”, и в нем должно быть записано имя контакта и атрибут “TelephoneNumber”
  со значением номера телефона.
    Задание 2
Создайте приложение, которое выводит на экран всю информацию об указанном .xml файле.
    Задание 3
Из файла TelephoneBook.xml (файл должен был быть создан в процессе выполнения
дополнительного задания) выведите на экран только номера телефонов. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 1. create Contact[]
            // 2. writexml(con)
            // 3. var cont = readXml(path);
            // foreach (c in cont)

            Contact[] phoneBook = new Contact[]
            {
                new Contact("Misha Dziamianchyk", "0938377673"),
                new Contact("Lena Ivankova", "0974567829"),
                new Contact("Dima Slepiankou", "038747203"),
                new Contact("Kostya Rubanau", "9978900292")
            };

            string path = @"F:\Tests\TelephoneBook.xml";
            WriteToXml(phoneBook, path);
            ShowXml(path);
        }

        public static void WriteToXml(Contact[] contacts, string path)
        {
            var file = new FileInfo(path);

            var xmlWriter = new XmlTextWriter(path, null);
            xmlWriter.Formatting = Formatting.Indented;

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");

            foreach (var c in contacts)
            {
                xmlWriter.WriteStartElement("Contact");
                xmlWriter.WriteStartAttribute("Name");
                xmlWriter.WriteString(c.Name);
                xmlWriter.WriteStartAttribute("TelephoneNumber");
                xmlWriter.WriteString(c.PhoneNumber);
                xmlWriter.WriteEndAttribute();
                xmlWriter.WriteEndElement();
            }
            xmlWriter.Close();
        }
        public static void ShowXml(string path)
        {
            var document = new XPathDocument(path);
            XPathNavigator navigator = document.CreateNavigator();
            XPathNodeIterator iterator = navigator.Select("MyContacts/Contact");
            while (iterator.MoveNext())
            {
                XPathNavigator navigator2 = iterator.Current.Clone();
                navigator2.MoveToFirstAttribute();
                var name = navigator2.Value;
                navigator2.MoveToNextAttribute();
                var number = navigator2.Value;
                Console.WriteLine("Name: {0}  Phone number: {1}", name, number);
            }
        }
    }
}
