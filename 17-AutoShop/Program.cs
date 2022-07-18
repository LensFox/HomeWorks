using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_AutoShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Auto auto1 = new Auto("Toyota", "Cayenne", 2009, "blue");
            //Auto auto2 = new Auto("BMW", "Nice", 2019, "grey");
            //Auto auto3 = new Auto("Lada", "Kalina", 20013, "red");
            //List<Auto> cars = new List<Auto> { auto1, auto2, auto3 };

            List<Auto> cars = new List<Auto>
            {
                new Auto("Toyota", "Cayenne", 2009, "blue"),
                new Auto("BMW", "Nice", 2019, "grey"),
                new Auto("Lada", "Kalina", 2013, "red")
            };

            Client client1 = new Client("Lada Kalina", "Slepenkov Dmitriy", "0975689");
            Client client2 = new Client("BMW", "Ivanov Sergey", "9876557");
            Client client3 = new Client("Lada Kalina", "Pavlov Alexandr", "9865578");
            List<Client> clients = new List<Client> { client1, client2, client3 };

            var query =
                from client in clients
                where client.clientName.Contains("Slepenkov")
                from auto in cars
                where client.carModel.Contains(auto.model)
                select new
                {
                    client = client.clientName,
                    clientPhoneNumber = client.clientPhoneNumber,
                    carModel = client.carModel,
                    year = auto.year,
                    colour = auto.colour,
                };
            foreach (var item in query)
            {
                Console.WriteLine($"Client name: {item.client}\n" +
                    $"Client phone number: {item.clientPhoneNumber}\n" +
                    $"Car model: {item.carModel}\n" +
                    $"Year: {item.year}\n" +
                    $"Colour: {item.colour}");
            }
        }
    }
}
