using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Notebook
{
    struct Notebook
    {
        string model;
        string manufacturer;
        decimal price;
        public Notebook(string model, string manufacturer, decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine($"Model: {model}\nManufacturer: {manufacturer}\nPrice: {price}\n");
        }
    }
}
