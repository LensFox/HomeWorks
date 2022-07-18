using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_IndexExperiments
{
    internal class Book
    {
        string title { get; set; }
        string author { get; set; }
        string publisher { get; set; }
        public Book(string title, string author, string publisher)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
        }
    }
}
