using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Handler
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("You have opened a TXT document");
        }
        public override void Create()
        {
            Console.WriteLine("You have created a TXT document");
        }
        public override void Change()
        {
            Console.WriteLine("You have changed a TXT document");
        }
        public override void Save()
        {
            Console.WriteLine("You have saved a TXT document");
        }
    }
}
