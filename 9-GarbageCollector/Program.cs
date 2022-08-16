using System;

namespace _9_GarbageCollector
{
    /*
     Дополнительное задание
Создайте свой класс, объекты которого будут занимать много места в памяти (например, в
коде класса будет присутствовать большой массив) и реализуйте для этого класса,
формализованный шаблон очистки.  
    Задание 2
Создайте класс, который позволит выполнять мониторинг ресурсов, используемых программой.
Используйте его в целях наблюдения за работой программы, а именно: пользователь может
указать приемлемые уровни потребления ресурсов (памяти), а методы класса позволят выдать
предупреждение, когда количество реально используемых ресурсов приблизиться к
максимально допустимому уровню. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            long memoryLimit = 0;
            try
            {
                Console.WriteLine("Hello! Enter the memory limit");
                memoryLimit = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            using (BigArrayClass ins = new())
            {
                Console.WriteLine(ins.arr[2]);
                Monitoring.Monitor(memoryLimit);
            }
        }
    }
}
