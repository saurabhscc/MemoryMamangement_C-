using System;
using System.Collections.Generic;
using System.Text;

namespace DisposeAndFinalize
{
    class DisposableTest : IDisposable
    {
        private bool disposed = false;
        public void Print(string message)
        {
            Console.WriteLine("Hello  "+ message);
        }
        ~DisposableTest()
        {
            Console.WriteLine("Destructor/finalize of DisposableTest");
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool dispose)
        {
            if (!disposed)
            {
                if (dispose)
                {
                    Console.WriteLine("Cleanup Managed Object");
                }
                Console.WriteLine("Cleanup unmanaged Object");
                disposed = true;
            }
        }
    }
}