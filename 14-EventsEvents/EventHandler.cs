using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_EventsEvents
{
    public delegate void EventHandlerBoom(string message, int counter);
    public delegate void Start();
    public class EventHandler
    {
        public event Start Starter;
        public event EventHandlerBoom One;
        public event EventHandlerBoom Two;
        public event EventHandlerBoom Three;
        public event EventHandlerBoom Four;
        public event EventHandlerBoom Five;
        public event EventHandlerBoom Six;
        int counter = 0;
        public void StarterMethod()
        {
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("How many events do you want to invoke?");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            var n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            break;
                        }
                    case 2:
                        {
                            var n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            break;
                        }
                    case 3:
                        {
                            var n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            break;
                        }
                    case 4:
                        {
                            var n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            break;
                        }
                    case 5:
                        {
                            var n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            break;
                        }
                    case 6:
                        {
                            var n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            n = random.Next(1, 6);
                            InvokeRandomEvent(n);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong number");
                            break;
                        }
                }
            }
        }
        public void InvokeStarter()
        {
            Starter?.Invoke();
        }
        public void InvokeRandomEvent(int n)
        {
            if (n == 1)
                this.One("Event One worked", ++counter);
            else if (n == 2)
                this.Two("Event Two worked", ++counter);
            else if (n == 3)
                this.Three("Event Three worked", ++counter);
            else if (n == 4)
                this.Four("Event Four worked", ++counter);
            else if (n == 5)
                this.Five("Event Five worked", ++counter);
            else if (n == 6)
                this.Six("Event Six worked", ++counter);
        }
    }
}
