using System;
using System.Reflection;

namespace _6_AssemblyInfo
{
    internal static class Info
    {
        public static void PrintClassInfo(object classInstance)
        {
            Type type = classInstance.GetType();
            Console.WriteLine("Name: {0}\n" +
                "Class: {1}\n" +
                "Base type: {2}\n" +
                "Sealed: {3}",
                type.FullName, type.IsClass, type.BaseType, type.IsSealed);
        }
        public static void PrintMethods(object classInstance)
        {
            Type type = classInstance.GetType();
            MethodInfo[] mi = type.GetMethods(BindingFlags.Instance | BindingFlags.Public |
                BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            foreach (MethodInfo m in mi)
                Console.WriteLine(m.Name);
            Console.WriteLine($"Class {type.Name} contains {mi.Length} methods");
        }
        public static void PrintFields(object classInstance)
        {
            Type type = classInstance.GetType();
            FieldInfo[] fi = type.GetFields(BindingFlags.Instance | BindingFlags.Public |
                BindingFlags.Static | BindingFlags.NonPublic);
            foreach (FieldInfo f in fi)
                Console.WriteLine(f.Name);
            Console.WriteLine($"Class {type.Name} contains {fi.Length} fields");
        }
        public static void PrintProperties(object classInstance)
        {
            Type type = classInstance.GetType();
            PropertyInfo[] pi = type.GetProperties();
            foreach (PropertyInfo p in pi)
                Console.WriteLine(p.Name);
            Console.WriteLine($"Class {type.Name} contains {pi.Length} fields");
        }
    }
}
