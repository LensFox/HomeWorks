using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Document
{
    abstract class AbstractDocument
    {
        public abstract void OpenDocument();

        public abstract void EditDocument();

        public abstract void SaveDocument();
        
    }
}
