using System;

namespace _6_ClassAndStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass superClass = new MyClass();
            MyStruct superStruct = new MyStruct("smth");
            var a = superStruct with { change = "smb" };
            //MyStruct superStruct1 = null;
            superClass.change = "NOT changed";
            //superStruct.change = "NOT changed";

            Console.WriteLine($"{0}, {1}", superClass.change, superStruct.change);

            ClassTaker(superClass);
            StructTaker(superStruct);

            Console.WriteLine($"{0}, {1}", superClass.change, superStruct.change);

        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed!";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed!";
        }
    }
}
