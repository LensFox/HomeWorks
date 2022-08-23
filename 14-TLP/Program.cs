using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _14_TLP
{
    /*
    Дополнительное задание
Создайте массив чисел размерностью в 1 000 000 или более. Используя генератор случайных
чисел, проинициализируйте этот массив значениями. Создайте PLINQ запрос, который
позволит получить все нечетные числа из исходного массива. 
    ShowOddNumbers()

    Задание 2
Создайте два метода, которые будут выполняться в рамках параллельных задач. Организуйте
вызов этих методов при помощи Invoke таким образом, чтобы основной поток программы
(метод Main) не остановил свое выполнение. 
     */
    internal class Program
    {
        static int[] array;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ShowOddNumbers();

            Task<int> task1 = new(Task1);
            Task task2 = new(Task2);
            task1.Start();
            task2.Start();
            Task.WaitAll(task1, task2);
            Console.WriteLine("Result of Task1: {0}", task1.Result);
        }
        static void ShowOddNumbers()
        {
            array = new int[1000000];
            Random random = new Random();
            Parallel.For(0, array.Length, i => array[i] = random.Next());

            ParallelQuery<int> oddNumbers = from el in array.AsParallel()
                                            where el % 2 == 0
                                            select el;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(oddNumbers.ToArray()[i]);
            }
        }
        static int Task1()
        {
            return array[5] * array[6] / 2;
        }
        static void Task2()
        {
            array[5] = 1;
            Console.WriteLine("Task 2 shows: {0}, {1}, {2}", array[4], array[5], array[6]);
        }
    }
}
