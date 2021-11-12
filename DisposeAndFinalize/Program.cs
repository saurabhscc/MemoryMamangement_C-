using System;

namespace DisposeAndFinalize
{
    class Program
    {
        static void Main(string[] args)
        {
            third objt = new third();
            Console.WriteLine("Third Object Created....");
            objt = null;
            Console.WriteLine("Assigned null ... object Destructing...");
            GC.Collect();
            Console.ReadLine();

            DisposableTest dsp = new DisposableTest();
            Console.WriteLine("Dispose Test Object created...");
            dsp.Print("Garbage collection");
            dsp.Dispose();
            dsp = null;
            Console.WriteLine("Assigned Null... Object Destructing...");

            Console.ReadLine();
        }
    }
}
