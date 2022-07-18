using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Document
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document is edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved as a current type." +
                "Saving as other types is available in version Expert");
        }
    }
}
