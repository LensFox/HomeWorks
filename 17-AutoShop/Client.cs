using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_AutoShop
{
    public class Client
    {
        public string carModel;
        public string clientName;
        public string clientPhoneNumber;
        public Client(string carModel, string clientName, string clientPhoneNumber)
        {
            this.clientName = clientName;
            this.clientPhoneNumber = clientPhoneNumber;
            this.carModel = carModel;
        }
    }
}
