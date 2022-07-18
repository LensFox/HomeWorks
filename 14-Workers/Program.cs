using System;
using System.Linq;

namespace _14_Workers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Worker[] shopStaff = new Worker[3];
            Worker gusev = new Worker("Gusev A.I.", "head of department", 2001);
            Worker sokolova = new Worker("Sokolova I.N.", "shop assistant", 2020);
            Worker utkin = new Worker("Utkin M.V.", "carrier", 2018);
            shopStaff[0] = gusev;
            shopStaff[1] = sokolova;
            shopStaff[2] = utkin;
            var orderedStaff = shopStaff.ToList().OrderBy
                (x => x.name).ToArray();
            shopStaff = orderedStaff;
            while (true)
            {
                Console.WriteLine("What do you want to do?\n" +
                    "1 - Add a worker\n" +
                    "2 - Find a worker");
                string userOperationChoice = Console.ReadLine();

                if (userOperationChoice == "1")
                {
                    Console.WriteLine("Enter the name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the position");
                    string position = Console.ReadLine();
                Label1:
                    Console.WriteLine("Enter the year the worker joined the company");
                    string year = Console.ReadLine();
                    int yearNumber = 0;
                    try
                    {
                        yearNumber = int.Parse(year);
                        DateTime currentDate = DateTime.Now;
                        int currentYear = currentDate.Year;
                        if (yearNumber > currentYear || yearNumber < 1950)
                        {
                            throw new Exception("Impossible year. Try again");
                        }

                        Worker newWorker = new Worker(name, position, yearNumber);
                        var a = Add(shopStaff, newWorker);
                        shopStaff = a;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Try again");
                        goto Label1;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Try again");
                        goto Label1;
                    }
                }
                else if (userOperationChoice == "2")
                {
                Label4:
                    Console.WriteLine("Enter the worker's experience");
                    string goalExperience = Console.ReadLine();
                    int goalExperienceNumber = 0;
                    try
                    {
                        goalExperienceNumber = int.Parse(goalExperience);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                   
                    DateTime currentDate = DateTime.Now;
                    int currentYear = currentDate.Year;

                    try
                    {
                        string nameCheck = null;
                        if (goalExperienceNumber <= (currentYear - 1950))
                        {
                            for (int i = 0; i < shopStaff.Length; i++)
                            {
                                if (currentYear - shopStaff[i].yearStartedWork >= goalExperienceNumber)
                                {
                                    Console.WriteLine(shopStaff[i].name);
                                    nameCheck = shopStaff[i].name;
                                }
                            }
                        }
                        else
                            throw new Exception("Impossible experience");
                        
                        if (nameCheck == null)
                            Console.WriteLine("Not found");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Label4;
                    }
                }
            }
        }
        public static Worker[] Add(Worker[] staff, Worker worker)
        {
            Worker[] newStaff = new Worker[staff.Length + 1];
            for (int i = 0; i < staff.Length; i++)
                newStaff[i] = staff[i];
            newStaff[newStaff.Length - 1] = worker;
            newStaff = newStaff.ToList().OrderBy
                (x => x.name).ToArray();
            Console.WriteLine("The worker has been added");
            return newStaff;
        }
    }
}
