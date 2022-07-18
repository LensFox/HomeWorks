using System;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyList<int> a = new MyList<int>(10);
            a.Add(44);
            Console.WriteLine($"{a[10]}, {a[5]}, {a[0]}, {a.numberOfElements}");
            a.GetArray();


        }
    }
}
