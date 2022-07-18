using System;

namespace _9_DelegateArray
{
    internal class Program
    {
        public delegate int CuteDelegate();
        public delegate int CuteArray(CuteDelegate[] a);
        static void Main(string[] args)
        {
            CuteDelegate[] a = new CuteDelegate[15];
            Random random = new Random();
            int sum = 0;

            CuteArray cuteArray = (a) =>
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = () => { return random.Next(0,20); };
                    sum += a[i]();
                }
                return sum / a.Length;
            };

            Console.WriteLine(cuteArray(a));




        }
    }
}
