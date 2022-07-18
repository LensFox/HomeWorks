using System;

namespace _7_Notebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Notebook pink = new Notebook("Flamingo", "China", 45.5m);
            Notebook green = new Notebook("Frog", "Ukraine", 15.44m);
            Notebook brown = new Notebook("Giraffe", "Egypt", 33m);
            Notebook purple = new Notebook("Lilac", "Canada", 61.10m);
            Notebook blue = new Notebook("Ocean", "USA", 25.30m);
            
            pink.Show();
            green.Show();
            brown.Show();
            purple.Show();
            blue.Show();


        }
    }
}
