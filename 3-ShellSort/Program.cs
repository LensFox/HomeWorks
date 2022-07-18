using System;

namespace _3_ShellSort
{
    internal class Program
    {

        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }
        static int[] ShellSort(int[] array)
        {

            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j -= d;
                    }
                }

                d = d / 2;
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Shell Sort");

            var array = new int[] { 10, 7, 6, 22, 9, 0, 1, 6, 3, 7 };

            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", ShellSort(array)));
        }
    }
}
