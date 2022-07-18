using System;

namespace _1_Books
{
    public class Book
    {
        public string Book1 { set; get; }

        public void Show()
        {
            Console.WriteLine($"Book: {Book1}");
        }
    }
    public class Title
    {
        public string Title1 { set; get; }
        public Title(string a)
        {
            Title1 = a;
        }
        public void Show()
        {
                       Console.WriteLine($"Title: {Title1}");
        }
    }
    public class Author
    {
        public string Author1 { set; get; }
        public Author(string a)
        {
           Author1 = a;
        }
        public void Show()
        {
            Console.WriteLine($"Author: {Author1}");
        }
    }
    public class Content
    {
        public string Content1 { set; get; }
        public Content(string a)
        {
            Content1 = a;
        }

        public void Show()
        {
            Console.WriteLine($"Content: {Content1}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the book title");
            string a = Console.ReadLine();
            Title one = new Title(a);
            Console.WriteLine("Enter the author's name");
            string b = Console.ReadLine();
            Author two = new Author(b);
            Console.WriteLine("Enter the content");
            string c = Console.ReadLine();
            Content three = new Content(c);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            one.Show();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            two.Show();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            three.Show();
            Console.ResetColor();
        }
    }
}
