using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Prices
{
    struct Price
    {
        public string itemName;
        public string shopName;
        public int price;
        public Price(string item, string shop, int price)
        {
            itemName = item;
            shopName = shop;
            this.price = price;
        }
    }
}
