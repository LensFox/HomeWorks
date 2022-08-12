using System;

namespace _7_Attributes
{
    internal class Program
    {
        /*
         Создайте пользовательский атрибут AccessLevelAttribute, позволяющий определить
уровень доступа пользователя к системе. Сформируйте состав сотрудников некоторой фирмы
в виде набора классов, например, Manager, Programmer, Director. При помощи атрибута
AccessLevelAttribute распределите уровни доступа персонала и отобразите на экране
реакцию системы на попытку каждого сотрудника получить доступ в защищенную секцию. 

        Задание 2
Создайте класс и примените к его методам атрибут Obsolete сначала в форме, просто
выводящей предупреждение, а затем в форме, препятствующей компиляции.
Продемонстрируйте работу атрибута на примере вызова данных методов.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Director petrov = new("Petrov I.A.");
            petrov.DoSmth();

            //petrov.DoSmth1();
            //petrov.DoSmth2();

            Console.WriteLine(new string ('-', 25));

            Programmer ivankova = new("Ivankova O.S.");
            ivankova.DoSmth();
        }
    }
}
