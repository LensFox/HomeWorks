using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Neo
{
    public class Matrix
    {
        public int[,] prettyMatrix;
        public Matrix(int lines, int columns)
        {
            prettyMatrix = new int[lines, columns];
            Random smth = new Random();
            for (int i = 0; i < prettyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < prettyMatrix.GetLength(1); j++)
                {
                    prettyMatrix[i, j] = smth.Next(0, 50);
                }
            }
        }
        public int this[int i, int j]
        {
            get { return prettyMatrix[i, j]; }
            set { prettyMatrix[i, j] = value; }
        }
        public void Show()
        {
            for (int i = 0; i < prettyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < prettyMatrix.GetLength(1); j++)
                {
                    Console.WriteLine(prettyMatrix[i, j]);
                }
            }
        }
    }
}
