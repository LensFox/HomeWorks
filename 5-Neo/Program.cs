using System;

namespace _5_Neo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! You're about to create a matrix.\n" +
                "How many lines do you want?");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many columns do you want?");
            int columns = Convert.ToInt32(Console.ReadLine());

            Matrix realMatrix = new Matrix(lines, columns);
            Matrix funnyMatrix = new Matrix(8, 5);
            Matrix grumpyMatrix = new Matrix(7, 7);

            Console.WriteLine("The user's matrix is:");
            Console.WriteLine(realMatrix[5, 6]);
            realMatrix.Show();
            Console.WriteLine(new string ('-',50));
            Console.WriteLine("The first pre-set matrix is:");
            funnyMatrix.Show();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The second pre-set matrix is:");
            grumpyMatrix.Show();
        }
        
       
    }
}
