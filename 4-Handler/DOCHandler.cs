using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Handler
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("You have opened a DOC document");
        }
        public override void Create()
        {
            Console.WriteLine("You have created a DOC document");
        }
        public override void Change()
        {
            Console.WriteLine("You have changed a DOC document");
        }
        public override void Save()
        {
            Console.WriteLine("You have saved a DOC document");
        }
    }
}
