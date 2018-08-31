using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO 1
            int? x = 10;
            if (x.HasValue)
            {
                Console.WriteLine($"x is {x.Value}");
            }
            else
            {
                Console.WriteLine("x does not have a value");
            }

            //EJEMPLO 2
            int? y = 7;
            if (y != null)
            {
                Console.WriteLine($"y is {y.Value}");
            }
            else
            {
                Console.WriteLine("y does not have a value");
            }

        }
    }
}
