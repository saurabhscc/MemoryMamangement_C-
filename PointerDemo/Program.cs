using System;

namespace PointerDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            unsafe
            {
                int var = 20;
                int* p = &var;//address area to pointer p
                Console.WriteLine("Data is : {0}", var);
                Console.WriteLine("Address is:{0}", (int)p);
                Console.ReadLine();
            }
        }
    }
}
