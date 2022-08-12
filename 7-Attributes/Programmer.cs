using System;

namespace _7_Attributes
{
    internal class Programmer
    {
        string _name;
        public Programmer(string name)
        {
            _name = name;
        }
        public void DoSmth()
        {
            Jobs.Rule(Type.GetType(ToString()));
            Jobs.WriteCode(Type.GetType(this.ToString()));

        }
    }
}
