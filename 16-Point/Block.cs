using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Point
{
    internal class Block
    {
        int a;
        int b;
        int c;
        int d;
        //IEquatable
        public Block(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override bool Equals(object obj)
        {
            if (obj is Block)
            {
                Block block = (Block)obj;
                if (a == block.a && b == block.b && c == block.c && d == block.d)
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return a ^ b ^ c ^ d;
        }

    }
}
