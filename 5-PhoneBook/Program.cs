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

            var file = new FileInfo(@"F:\Tests\TelephoneBook.xml");

            var xmlWriter = new XmlTextWriter(@"F:\Tests\TelephoneBook.xml", null);
            xmlWriter.Formatting = Formatting.Indented;

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("Name");
            xmlWriter.WriteString("VasyaShyshkin");
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("098655345");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.Close();

            string path = @"F:\Tests\TelephoneBook.xml";

            ShowPhoneNumbers(path);

        }
        public static void ShowXml(string path)
        {
            var document = new XmlDocument();
            document.Load(path);

            Console.WriteLine(document.InnerXml);
        }
        public static void ShowPhoneNumbers(string path)
        {
            var document = new XPathDocument(path);
            XPathNavigator navigator = document.CreateNavigator();
            XPathNodeIterator iterator = navigator.Select("MyContacts/Contact");
            while (iterator.MoveNext())
            {
                XPathNavigator navigator2 = iterator.Current.Clone();
                navigator2.MoveToFirstAttribute();
                navigator2.MoveToNextAttribute();
                Console.WriteLine(navigator2.Value);
            }



        }
    }
}
