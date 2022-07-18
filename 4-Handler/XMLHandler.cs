using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Handler
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("You have opened an XML document");
        }
        public override void Create()
        {
            Console.WriteLine("You have created an XML document");
        }
        public override void Change()
        {
            Console.WriteLine("You have changed an XML document");
        }
        public override void Save()
        {
            Console.WriteLine("You have saved a XML document");
        }
    }
}
