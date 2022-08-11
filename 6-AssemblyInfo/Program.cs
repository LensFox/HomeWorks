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
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass instance = new MyClass();
            Info.PrintClassInfo(instance);

            //2,3
            string path = @"F:\My Projects\6-TempConverter\bin\Debug\net5.0\6-TempConverter.dll";
            var assembly = Assembly.LoadFrom(path);
            //Type[] types = assembly.GetTypes();
            Type type = assembly.GetType("_6_TempConverter.Converter");

            double t = 20;
            object[] par = new object[] { t };
            MethodInfo convert = type.GetMethod("CtoF");

            convert.Invoke(null, par);
        }
    }
}
