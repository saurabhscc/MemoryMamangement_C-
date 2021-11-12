using System;

namespace GarbageCollectionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                // Allocate an array and make it unreachable.
                int[] values = new int[50000];
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                // Collect garbage.
                GC.Collect();
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine("Use of GC.Collect :");
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }
            Console.WriteLine("************************");
            Console.WriteLine("Use of Collection Counts:");

            // This loop does a lot of allocations!
            for (int i = 0; i < 100; i++)
            {
                for (int a = 0; a < 1000; a++)
                {
                    System.IO.Path.GetRandomFileName();
                    System.IO.Path.GetRandomFileName();
                }
                System.Threading.Thread.Sleep(1);
            }

            // Display collection counts.
            for (int i = 0; i <= GC.MaxGeneration; i++)
            {
                int count = GC.CollectionCount(i);
                Console.WriteLine(count);
            }

            Console.WriteLine("************************");
            Console.WriteLine("Use Of GC :");

            long bytes1 = GC.GetTotalMemory(false); // Get memory in bytes

            byte[] memory = new byte[1000 * 1000 * 10]; // Ten million bytes
            memory[0] = 1; // Set memory (prevent allocation from being optimized out)

            long bytes2 = GC.GetTotalMemory(false); // Get memory
            long bytes3 = GC.GetTotalMemory(true); // Get memory

            Console.WriteLine(bytes1);//program start with these bytes
            Console.WriteLine(bytes2);//memory allocated after ten milloin
            Console.WriteLine(bytes2 - bytes1); // Write difference
            Console.WriteLine(bytes3);//after garbage collection
            Console.WriteLine(bytes3 - bytes2); // Write difference
            Console.ReadLine();
        }
    }
}
