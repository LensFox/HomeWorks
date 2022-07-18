using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_RandomArray
{
    public class MyArray
    {
        public int[] array;
        public MyArray(int dimension)
        {
            array = new int[dimension];
        }
        public int this [int index]
        {
            get { return array [index]; }
            set { array [index] = value; }
        }

        
    }
}
