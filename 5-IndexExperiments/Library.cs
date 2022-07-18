using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_IndexExperiments
{
    internal class Library
    {
       Book[] listOfBooks;
       public Library(params Book[] a)
        {
            listOfBooks = a;
        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < listOfBooks.Length; i++)

                    if (index == listOfBooks[i].title)
                        return string.Format(listOfBooks[i].title + "  " + listOfBooks[i].author + "  "
                            + listOfBooks[i].publisher);

                return string.Format(index + " - not found");

            }
        }
    }

