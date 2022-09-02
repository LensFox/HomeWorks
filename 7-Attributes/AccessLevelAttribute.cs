using System;

namespace _7_Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class AccessLevelAttribute : System.Attribute
    {
        private readonly string _userType;
        public string UserType
        {
            get { return _userType; }
        }
        public AccessLevelAttribute(string userType)
        {
            _userType = userType;
        }
        public string UseComment { get; set; }
    }
}
