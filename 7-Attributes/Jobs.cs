using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _7_Attributes
{
    public static class Jobs
    {
        [AccessLevel("_7_Attributes.Director", UseComment = "Access for directors only")]
        public static void Rule(Type type)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            if (IsAccessAllowed(type, method, out string message))
            {
                Console.WriteLine("I rule the company");
            }
            else
            {
                Console.WriteLine(message);
            }
        }
        [AccessLevel("_7_Attributes.Programmer", UseComment = "Access for programmers only")]
        public static void WriteCode(Type type)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            
            if (IsAccessAllowed(type, method, out string message))
            {
                Console.WriteLine("I write code in the company");
            }
            else
            {
                Console.WriteLine(message);
            }
        }
        [AccessLevel("_7_Attributes.Manager", UseComment = "Access for the director and managers")]
        [AccessLevel("_7_Attributes.Director", UseComment = "Access for the director and managers")]
        public static void TalkToClients(Type type)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            if (IsAccessAllowed(type, method, out string message))
            {
                Console.WriteLine("I talk to clients in the company");
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        [AccessLevel("_7_Attributes.Manager", UseComment = "access ")]
        public static void ManageStuff(Type type)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            if (IsAccessAllowed(type, method, out string message))
            {
                Console.WriteLine("I manage stuff in the company");
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        public static bool IsAccessAllowed(Type type, MethodBase method, out string message)
        {
            object[] methodAttributes = method.GetCustomAttributes(typeof(AccessLevelAttribute), false);
            foreach (AccessLevelAttribute attribute in methodAttributes)
            {
                if (attribute.UserType != type.ToString())
                {
                    message = attribute.UseComment;
                    return false;
                }
            }
            message = null;
            return true;
        }
    }
}
