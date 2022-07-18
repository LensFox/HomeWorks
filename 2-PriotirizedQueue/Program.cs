using System;

namespace _2_PriotirizedQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                TasksQueue<string> tasksQueue = new TasksQueue<string>();
                tasksQueue.AddFirst("do this");
                tasksQueue.AddFirst("No, do that");
                tasksQueue.AddLast("And this too");

                foreach (var task in tasksQueue)
                    Console.WriteLine(task);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           

        }
    }
}
