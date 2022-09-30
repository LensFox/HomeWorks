using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ThreeLayerProject.BLL
{
    public interface ICalcService
    {
        public int Add(int a, int b);
        public int Substract(int a, int b);
        public int Multiply(int a, int b);
        public int Divide(int a, int b);
    }
}
