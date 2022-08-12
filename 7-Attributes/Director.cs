using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Attributes
{
    internal class Director
    {
        string _name;
        public Director(string name)
        {
            _name = name;
        }
       
        public void DoSmth()
        {
            Jobs.Rule(Type.GetType(ToString()));
            Jobs.WriteCode(Type.GetType(this.ToString()));

        }
        [Obsolete("The method is old", false)]
        public void DoSmth1()
        {
            Jobs.Rule(Type.GetType(ToString()));
            Jobs.WriteCode(Type.GetType(this.ToString()));

        }
        [Obsolete("The method is old", true)]
        public void DoSmth2()
        {
            Jobs.Rule(Type.GetType(ToString()));
            Jobs.WriteCode(Type.GetType(this.ToString()));

        }
    }
}
