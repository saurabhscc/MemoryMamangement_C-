using System;
using System.Collections.Generic;
using System.Text;

namespace DisposeAndFinalize
{
    class first
    {
        public first()
        {
            Console.WriteLine("Creating First");
        }
        ~first()
        {
            Console.WriteLine("Destructor First");
        }
    }

    class second : first
    {
        public second()
        {
            Console.WriteLine("Creating Second");
        }
        ~second()
        {
            Console.WriteLine("Destructor Second");
        }
    }

    class third : second
    {
        public third()
        {
            Console.WriteLine("Creating Third");
        }
        ~third()
        {
            Console.WriteLine("Destructor Third");
        }
    }
}