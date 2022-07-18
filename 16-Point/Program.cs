using System;

namespace _16_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point one = new Point(7, 8, 9);
            Point two = new Point(5, 9, 2);
            Point three = one + two;

            Console.WriteLine("x: {0}, y:{1}, z:{2}", three.x, three.y, three.z);
            //Console.WriteLine($"x: {three.x}, y:{ three.y}, z:{ three.z}");

            Block aa = new Block(3, 5, 7, 2);
            Block bb = new Block(3, 5, 2, 2);
            Console.WriteLine(aa.Equals(bb));
        }
    }
}
