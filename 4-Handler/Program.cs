using System;

namespace _4_Handler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What document type do you want to work with? Enter\n" +
                "1 for DOC\n2 for TXT\n3 for XML");
            string documentType = Console.ReadLine();
            Console.WriteLine("What do you want to do? Enter\n" +
                    "1 to create\n2 to open\n3 to change\n4 to save");
            string operation = Console.ReadLine();
            if (documentType == "1")
            {
                DOCHandler document = new DOCHandler();
                //if (operation == "1")
                //{
                //    document.Create();
                //}
                //else if (operation == "2")
                //{
                //    document.Open();
                //}
                //else if (operation == "3")
                //{
                //    document.Change();
                //}
                //else if (operation == "4")
                //{
                //    document.Save();
                //}
                //else
                //{
                //    Console.WriteLine("Unknown operation");
                //}
                ChooseOperation(document, operation);
            }
            else if (documentType == "2")
            {
                TXTHandler document = new TXTHandler();
                ChooseOperation(document, operation);
            }
            else if (documentType == "3")
            {
                XMLHandler document = new XMLHandler();
                ChooseOperation(document, operation);

            }
            else
            {
                Console.WriteLine("Unknown type");
            }
        }
        public static void ChooseOperation(AbstractHandler document, string operation)
        {
            if (operation == "1")
            {
                document.Create();
            }
            else if (operation == "2")
            {
                document.Open();
            }
            else if (operation == "3")
            {
                document.Change();
            }
            else if (operation == "4")
            {
                document.Save();
            }
            else
            {
                Console.WriteLine("Unknown operation");
            }
        }
    }
}
