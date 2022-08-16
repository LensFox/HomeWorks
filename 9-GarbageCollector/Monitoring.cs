using System;

namespace _9_GarbageCollector
{
    internal static class Monitoring
    {
        internal static void Monitor(long memoryLimit)
        {
            var memoryUsed = GC.GetTotalMemory(false);
            Console.WriteLine(memoryUsed);
            try
            {
                if (memoryUsed > memoryLimit && memoryLimit != 0)
                {
                    throw new Exception("You have exceeded the memory limit");
                }
                else if (memoryLimit == 0)
                {
                    throw new Exception("Invalid input format");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
