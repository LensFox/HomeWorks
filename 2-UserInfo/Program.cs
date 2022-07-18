using System;

namespace _2_UserInfo
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public DateTime Date { get; }
        public User(string login, string name, string surname, string age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            Date = DateTime.Now;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            User Vasya = new User("Parapaparam", "Vasiliy", "Petrov", "22");
            Console.WriteLine($"Login: {Vasya.Login}\nName: {Vasya.Name} {Vasya.Surname}\n" +
                $"Age: {Vasya.Age}\nDate: {Vasya.Date}");
            User Tanya = new User("Bingo", "Tatyana", "Sokolova", "34");
            Console.WriteLine($"Login: {Tanya.Login}\nName: {Tanya.Name} {Tanya.Surname}\n" +
                $"Age: {Tanya.Age}\nDate: {Tanya.Date}");
        }
    }
}
