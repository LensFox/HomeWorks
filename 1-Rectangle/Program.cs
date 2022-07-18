using System;

namespace _1_Rectangle
{
    public class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Area { get { return Side1 * Side2; } }
        public double Perimeter { get { return (Side1 + Side2) * 2; } }
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        internal void AreaCalculator()
        {
            Console.WriteLine($"Area: {Area}");
        }
        internal void PerimeterCalculator()
        {
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
        
    }
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the length of the first side");
            var side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side");
            var side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle myRectangle = new Rectangle(side1, side2);
            myRectangle.AreaCalculator();
            myRectangle.PerimeterCalculator();
        }
    }
}
