using System;

namespace _3_Transport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Zhyguli = new Car(70, 300, 1975);
            Plane Mriya = new Plane(300, 200000, 2008, 260, 3000);
            Ship Parohod = new Ship(150, 100000, 1999, 120, "Odessa");

            Zhyguli.Show();
            Mriya.Show();
            Parohod.Show();
        }
    }
}
