using System;

namespace _5_RandomArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array length");
            int a = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            MyArray myArray = new MyArray(a);
            for (int i = 0; i < myArray.array.Length; i++)
            {
                myArray[i] = random.Next(0, 20);
            }
            Array.Sort(myArray.array);
            Console.WriteLine($"Max element: {myArray[a-1]}");
            Console.WriteLine($"Min element: {myArray[0]}");
            int sum = 0;
            for (int i = 0; i < myArray.array.Length; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine($"The sum of all elements: {sum}");

            Console.WriteLine($"The arithmetical mean is {sum / myArray.array.Length}");

            Console.WriteLine("The odd numbers are:");
            for (int i = 0; i < myArray.array.Length; i++)
            {
                double remainder = myArray.array[i] % 2;
                if (remainder != 0)
                    Console.WriteLine(myArray.array[i]);
            }
        }
    }
}
