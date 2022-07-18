using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Document
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument() //override is necessary? It worked before
        {
            Console.WriteLine("Document is saved as a new type");
        }
    }
}
