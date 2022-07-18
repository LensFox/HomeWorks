using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Document
{
    internal class DocumentWorker : AbstractDocument
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Editing is available in version Pro");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Saving is available in version Pro");
        }
    }
}
