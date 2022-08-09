using System;
using System.Text.RegularExpressions;

namespace _4_LoginAndPassword
{
    /*
     Дополнительное задание
Напишите консольное приложение, позволяющие пользователю зарегистрироваться под
«Логином», состоящем только из символов латинского алфавита, и пароля, состоящего из
цифр и символов.  
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Label:
            Console.WriteLine("Hello! Enter your login");
            string login = Console.ReadLine();

            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            const string loginPattern = @"^[a-z]+$";
            const string passwordPattern = @"^[a-z0-9]+$";
            var loginCheck = new Regex(loginPattern);
            var passwordCheck = new Regex(passwordPattern);
            try
            {
                if (!loginCheck.IsMatch(login))
                    throw new Exception("Incorrect login format");
                if (!passwordCheck.IsMatch(password))
                    throw new Exception("Incorrect password format");
                else
                    Console.WriteLine("You've logged in successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Try again\n");
                goto Label;
            }
        }
    }
}
