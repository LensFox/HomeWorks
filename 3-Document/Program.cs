using System;

namespace _3_Document
{
    internal class Program
    {
        const string KeyPro = "112233";
        const string KeyExpert = "223344";
        static void Main(string[] args)
        {
            Console.Write("Hello! Enter the key: ");
            string userKey = Console.ReadLine(); 
            if (userKey == KeyPro)
            {
                Console.WriteLine("You have a Pro version");
                ProDocumentWorker application = new ProDocumentWorker();
                //application.OpenDocument();
                //application.EditDocument();
                //application.SaveDocument();
                Show(application);
            }
            else if (userKey == KeyExpert)
            {
                Console.WriteLine("You have an Expert version");
                ExpertDocumentWorker application = new ExpertDocumentWorker();
                Show(application);
            }
            else
            {
                Console.WriteLine("You have a free version");
                DocumentWorker application = new DocumentWorker();
                Show(application);
            }
        }
        public static void Show(AbstractDocument application)
        {
            application.OpenDocument();
            application.EditDocument();
            application.SaveDocument();
        }
    }
}
