using System;
using System.Reflection;

namespace _6_AssemblyInfo
{
    internal static class Info
    {
        public static void PrintAssemblyInfo(Assembly assembly)
        {
            Type[] assemblyTypes = assembly.GetTypes();
            foreach (Type typ in assemblyTypes)
            {
                Console.WriteLine("Type: {0}, IsPublic:{1}", typ.Name, typ.IsPublic);
            }
        }
        public static void PrintMethods(Assembly assembly)
        {
            Type[] assemblyTypes = assembly.GetTypes();
            foreach (Type typ in assemblyTypes)
            {
                MethodInfo[] mi = typ.GetMethods(BindingFlags.Instance | BindingFlags.Public |
                    BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                foreach (MethodInfo m in mi)
                    Console.WriteLine(m.Name);
                Console.WriteLine($"Class {typ.Name} contains {mi.Length} methods");
            }
        }
        public static void PrintFields(Assembly assembly)
        {
            Type[] assemblyTypes = assembly.GetTypes();
            foreach (Type typ in assemblyTypes)
            {
                FieldInfo[] fi = typ.GetFields(BindingFlags.Instance | BindingFlags.Public |
                 BindingFlags.Static | BindingFlags.NonPublic);
                foreach (FieldInfo f in fi)
                    Console.WriteLine(f.Name);
                Console.WriteLine($"Class {typ.Name} contains {fi.Length} fields");
            }
        }
        public static void PrintProperties(Assembly assembly)
        {
            Type[] assemblyTypes = assembly.GetTypes();
            foreach (Type typ in assemblyTypes)
            {
                PropertyInfo[] pi = typ.GetProperties();
                foreach (PropertyInfo p in pi)
                    Console.WriteLine(p.Name);
                Console.WriteLine($"Class {typ.Name} contains {pi.Length} fields");
            }
        }
    }
}
