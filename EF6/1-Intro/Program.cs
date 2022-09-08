using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Intro
{
    /*
    Задание
Используя Visual Studio, создайте проект по шаблону Windows Forms Application.
Требуется:
Создайте базу данных MyDatabase с таблицей MyTable.
Создайте модель сущностей созданной базы данных, т.е. Entity Data Model с именем по умолчанию
(Model1.edmx) используя технику Database First.
Добавьте на форму DataGridView и Button.
Релизуйте возможность вывода информации в DataGridView по нажатию на Button.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var contextEntities = new MyDatabase2Entities();
            var list = contextEntities.Tables.ToList();

            foreach (var item in list)
            {
                Console.WriteLine("{0}) {1} {2} {3}", item.Id, item.FName, item.LName, item.Age);
            }
            Console.ReadKey();
        }
    }
}
