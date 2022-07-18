using System;

namespace _1_Figure
{
    public class Point
    {
        public int A { get; }
        public int B { get; }
        public string Name { get; }
        public Point(int a, int b, string name)
        {
            this.A = a;
            this.B = b;
            this.Name = name;
        }
    }
    public class Figure
    {
        Point A { set; get; }
        Point B { set; get; }
        Point C { set; get; }
        Point D { set; get; }
        Point E { set; get; }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((a.A - b.A), 2) + Math.Pow((a.B - b.B), 2));
        }
        public void Perimeter(Point a, Point b, Point c, Point d, Point e)
        {
            double sideOneLength = LengthSide(a, b);
            double sideTwoLength = LengthSide(b, c);
            double sideThreeLength = LengthSide(c, d);
            double sideFourLength = LengthSide(d, e);
            double sideFiveLength = LengthSide(e, a);
            Console.WriteLine($"Perimeter is:" +
                $"{sideOneLength + sideTwoLength + sideThreeLength + sideFourLength + sideFiveLength}" +
                $"\nYour figure is a pentagon.");
        }
        public void Perimeter(Point a, Point b, Point c, Point d)
        {
            double sideOneLength = LengthSide(a, b);
            double sideTwoLength = LengthSide(b, c);
            double sideThreeLength = LengthSide(c, d);
            double sideFourLength = LengthSide(d, a);
            Console.WriteLine($"Perimeter is: {sideOneLength + sideTwoLength + sideThreeLength + sideFourLength}\n Your figure is a square");
        }
        public void Perimeter(Point a, Point b, Point c)
        {
            double sideOneLength = LengthSide(a, b);
            double sideTwoLength = LengthSide(b, c);
            double sideThreeLength = LengthSide(c, a);
            Console.WriteLine($"Perimeter is: {sideOneLength + sideTwoLength + sideThreeLength}\n Your figure is a triangle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! How many points do you have?");
            int numberOfPoints = Convert.ToInt32(Console.ReadLine());
            Point A = new Point(0, 0, "name");
            Point B = new Point(0, 0, "name");
            Point C = new Point(0, 0, "name");
            Point D = new Point(0, 0, "name");
            Point E = new Point(0, 0, "name");
            if ((numberOfPoints < 6) || (numberOfPoints > 2))
            {
                for (int i = 0; i < numberOfPoints; i++)
                {
                    Console.WriteLine($"Enter the X coordinate of the {i+1} point");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter the Y coordinate of the {i+1} point");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter the name for the {i+1} point");
                    string n = Console.ReadLine();
                    if (i == 0)
                    {
                        A = new Point(x, y, n);
                    }
                    else if (i == 1)
                    {
                        B = new Point(x, y, n);
                    }
                    else if (i == 2)
                    {
                        C = new Point(x, y, n);
                    }
                    else if (i == 3)
                    {
                        D = new Point(x, y, n);
                    }
                    else
                    {
                        E = new Point(x, y, n);
                    }
                }

                if (numberOfPoints == 3)
                {
                    var figure = new Figure(A, B, C);
                    figure.Perimeter(A, B, C);
                }
                if (numberOfPoints == 4)
                {
                    var figure = new Figure(A, B, C, D);
                    figure.Perimeter(A, B, C, D);
                }
                else
                {
                    var figure = new Figure(A, B, C, D, E);
                    figure.Perimeter(A, B, C, D, E);
                }
            }
            else
            {
                Console.WriteLine("Invalid number or character!");

            }
        }
    }
}

