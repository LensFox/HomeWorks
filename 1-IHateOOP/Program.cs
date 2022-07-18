using System;

namespace _1_IHateOOP
{
    internal class Address
    {
        private string index { set; get; }
        private string country { set; get; }
        private string city { set; get; }
        private string street { set; get; }
        private string house { set; get; }
        private string apartment { set; get; }
       
        public Address(string index, string country, string city)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            
        }
        public void Show()
        {
            Console.WriteLine($"Index: {index}\n Country: {country}\n City: {city}\n Street: {street}");
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Address tom = new Address("6567", "Great Britain", "London");
                tom.Show();
            }
        }
    }
}
