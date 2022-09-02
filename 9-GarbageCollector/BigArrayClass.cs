using System;

namespace _9_GarbageCollector
{
    internal class BigArrayClass : IDisposable
    {
        internal int[] arr = new int[1000000];
        internal int[] arr2 = new int[100000];
        private bool disposed = false;
        public void Dispose()
        {
            Console.WriteLine("Dispose");
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose(bool)");
                }
                disposed = true;
            }
        }
        ~BigArrayClass()
        {
            Dispose(false);
            Console.WriteLine("Destructor");
        }
    }
}
