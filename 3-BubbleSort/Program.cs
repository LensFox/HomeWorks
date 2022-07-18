using System;

namespace _3_BubbleSort
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)

        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.WriteLine(array[i]);
            }
            BubbleSort(ref array);
            Console.WriteLine("-", 20);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
        public static void BubbleSort(ref int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
            }
        }
    }

