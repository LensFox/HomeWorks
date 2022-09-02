using System;
using System.Reflection;

namespace _6_AssemblyInfo
{
    /*
     Создайте программу-рефлектор, которая позволит получить информацию о сборке и входящих
в ее состав типах. Для основы можно использовать программу-рефлектор из урока.

    Задание 2
Создайте свою пользовательскую сборку по примеру сборки CarLibrary из урока, сборка будет
использоваться для работы с конвертером температуры.

    Задание 3
Создайте программу, в которой предоставьте пользователю доступ к сборке из Задания 2.
Реализуйте использование метода конвертации значения температуры из шкалы Цельсия в
шкалу Фаренгейта. Выполняя задание используйте только рефлексию.

    урок 7 - Атрибуты
    Задание 3
Расширьте возможности программы-рефлектора из предыдущего урока следующим образом:
1. Добавьте возможность выбирать, какие именно члены типа должны быть показаны
пользователю. При этом должна быть возможность выбирать сразу несколько членов
типа, например, методы и свойства.
2. Добавьте возможность вывода информации об атрибутах для типов и всех членов типа,
которые могут быть декорированы атрибутами. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string path = @"F:\My Projects\6-TempConverter\bin\Debug\net5.0\6-TempConverter.dll";
            var assembly = Assembly.LoadFrom(path);
            Info.PrintAssemblyInfo(assembly); //and lesson 7 - task 3 

            Console.ReadKey();

            //урок 7 - Задание 3
            Console.WriteLine("Hello! What would you like to see?\n" +
                "Press 1 - Classes\n" +
                "Press 2 - Methods\n" +
                "Press 3 - Properties\n" +
                "Press 4 - Fields\n" +
                "You can enter several options, with spaces");
            string userChoice = Console.ReadLine();

            string[] choices = userChoice.Split(' ', 4);
            for (int i = 0; i < choices.Length; i++)
            {
                if (choices[i] == "1")
                {
                    Info.PrintAssemblyInfo(assembly);
                }
                else if (choices[i] == "2")
                {
                    Info.PrintMethods(assembly);
                }
                else if (choices[i] == "3")
                {
                    Info.PrintProperties(assembly);
                }
                else if (choices[i] == "4")
                {
                    Info.PrintFields(assembly);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
            
            //2,3
            Type type = assembly.GetType("_6_TempConverter.Converter");

            double t = 20;
            object[] par = new object[] { t };
            MethodInfo convert = type.GetMethod("CtoF");

            convert.Invoke(null, par);
        }
    }
}
