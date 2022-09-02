using System;
using System.Collections.Specialized;

namespace _2_CustomersInfo
{
    /*
     Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими
продукции. Из коллекции можно получать категории товаров, которые купил покупатель или по
категории определить покупателей.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NameValueCollection customerProductInfo = new();

            customerProductInfo.Add("Ivanov", "vacuum cleaner");
            customerProductInfo.Add("Ivanov", "TV set");
            customerProductInfo.Add("Shyshkin", "mobile phone");
            customerProductInfo.Add("Shyshkin", "earphones");
            customerProductInfo.Add("Shyshkin", "speaker");
            customerProductInfo.Add("Myshkin", "vacuum cleaner");

            Console.WriteLine(customerProductInfo["Ivanov"]);
            Console.WriteLine(customerProductInfo["Shyshkin"]);

            GetAllKeys(customerProductInfo, "vacuum cleaner");
        }

        public static void GetAllKeys(NameValueCollection col, string userValue)
        {
            foreach (string k in col.Keys)
            {
                foreach (string value in col.GetValues(k))
                {
                    if (value == userValue)
                        Console.WriteLine(k);
                }
            }
        }
    }
}
