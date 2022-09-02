using System;

namespace _10_Polymorphism
{
    /*
     Дополнительное задание
Реализуйте шаблон NVI в собственной иерархии наследования. 
    Задание 2
Выучите описание шаблона Template method (Шаблонный метод). Обратите внимание на
применимость шаблона, а также на состав его участников и связи отношения между ними.
Напишите небольшую программу на языке C#, представляющую собой абстрактную
реализацию данного шаблона. 
    
    Бонус: обмен значений переменных через кортеж =)
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NVIusage ins = new();
            ins.Method3();

            //ExchangeValueTupleCheck();
        }
        public static void ExchangeValueTupleCheck()
        {
            int a = 2, b = 3;
            Console.WriteLine("a = {0}, b = {1}", a, b);

            (a, b) = (b, a);
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
