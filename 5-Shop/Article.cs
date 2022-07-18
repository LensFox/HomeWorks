using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Shop
{
    internal class Article
    {
        string Item { set; get; }
        string Shop { set; get; }
        int Price { set; get; }
        public Article(string item, string shop, int price)
        {
            Item = item;
            Shop = shop;
            Price = price;
        }
       
        public string FindByItemInArticle(string item)
        {
            if (item == Item)
                return string.Format(Item + " " + Shop + " " + Price);
            else
                return null;
        }
        public string Show()
        {
            return string.Format (Item + " " + Shop +" " + Price);

        }
    }
}