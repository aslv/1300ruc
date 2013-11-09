using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursion
{
    class Examples
    {
        static ulong Fibonacci(uint n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static ulong Factorial(uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            string message = "The {0}-th number of Fibbonacci is {1}";
            //string message = "The factorial of {0} is {1}";
            ulong result = Fibonacci(number);
            //ulong result = Factorial(number);
            Console.WriteLine(message, number, result);
        }
    }
}
