using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Shop
{
    internal class Store
    {
        Article[] ListOfItemsInTheStore;

        public Store(int length, params Article[] a)
        {
            ListOfItemsInTheStore = new Article[length];
            for (int i = 0; i < a.Length; i++)
                ListOfItemsInTheStore[i] = a[i];
        }
        public string this[string index]
        {
            get
            {
                string result;
                for (int i = 0; i < ListOfItemsInTheStore.Length; i++)
                {
                    result = ListOfItemsInTheStore[i].FindByItemInArticle(index);
                    if (!string.IsNullOrEmpty(result))
                    {
                        return result;
                    }    
                }
                return null;
            }
        }
        public string this[int index]
        {
            get
            {
                for (int i = 0; i < ListOfItemsInTheStore.Length; i++)
                {
                    if (index == i + 1)
                        return ListOfItemsInTheStore[i].Show();
                }
                return null;
            }

        }
        
    }
    interface Ismth

}
