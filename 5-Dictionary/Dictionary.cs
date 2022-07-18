using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Dictionary
{
    public class Dictionary
    {
        public string[] russian = new string[5];
        public string[] english = new string[5];
        public string[] ukrainian = new string[5];
        public Dictionary()
        {
            russian[0] = "ноутбук"; english[0] = "laptop"; ukrainian[0] = "ноутбук";
            russian[1] = "стол"; english[1] = "table"; ukrainian[1] = "стіл";
            russian[2] = "кофе"; english[2] = "coffee"; ukrainian[2] = "кава";
            russian[3] = "фарфор"; english[3] = "porcelain"; ukrainian[3] = "порцеляна";
            russian[4] = "стакан"; english[4] = "glass"; ukrainian[4] = "склянка";
        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < russian.Length; i++)
                    if (index == english[i])
                        return string.Format(english[i] + "  -  " + russian[i] + "  -  " + ukrainian[i]);
                    else if (index == ukrainian[i])
                        return string.Format(ukrainian[i] + "  -  " + russian[i] + "  -  " + english[i]);
                    else if (index == russian[i])
                        return string.Format(russian[i] + "  -  " + ukrainian[i] + "  -  " + english[i]);
                return string.Format(index + " - can't traslate");
            }
        }
    }
}

