using System;

namespace _10_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = MyClass<int>.FactoryMethod();
            string name = MyClass<string>.FactoryMethod();
            char surname = MyClass<char>.FactoryMethod();
            age = 29;
            name = "Lena";
            surname = 'I';
            Console.WriteLine($"{name} {surname}, {age}");
        }
    }
}
