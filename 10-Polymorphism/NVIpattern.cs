using System;

namespace _10_Polymorphism
{
    internal class NVIpattern
    {
        public void InterfaceMethod()
        {
            Method1();
            Method2();
        }
        protected virtual void Method1()
        {
            Console.WriteLine("Method1");
        }
        protected virtual void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
    internal class NVIusage : NVIpattern
    {
        public void Method3()
        {
            InterfaceMethod();
        }
        protected override void Method1()
        {
            Console.WriteLine("Method1 overriden");
        }
    }
}
