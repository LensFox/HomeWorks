using System;

namespace _5_IndexExperiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Book alice = new Book("Alice in Wonderland", "L. Caroll", "Penguin");
            Book toKillAMockingbird = new Book("To Kill A Mockingbird", "H. Lee", "Bookworms");
            Book inColdBlood = new Book("In Cold Blood", "T. Capote", "New Yorker");
            Book grapesOfWrath = new Book("Grapes Of Wrath", "J. Steinbeck", "New York Times Publishing");

            Library allBooks = new Library(alice, toKillAMockingbird, inColdBlood, grapesOfWrath);

            Console.WriteLine("Which book do you want?");
            string targetBook = Console.ReadLine();
            Console.WriteLine(allBooks[targetBook]);

            //string title = null;
            //string author = null;
            //string publisher = null;
            //for (int i = 0; i < allBooks.listOfBooks.Length; i++)
            //{
            //    if (targetBook == allBooks.listOfBooks[i].title)
            //    {
            //        title = allBooks.listOfBooks[i].title;
            //        author = allBooks.listOfBooks[i].author;
            //        publisher = allBooks.listOfBooks[i].publisher;
            //    }
            //}
            //if (title != null)
            //    Console.WriteLine($"{title} - {author} - {publisher}");
            //else
            //    Console.WriteLine($"{targetBook} - not found");
        }
    }
}
