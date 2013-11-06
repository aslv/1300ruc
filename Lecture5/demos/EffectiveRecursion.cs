using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursion
{
    class EffectiveRecursion
    {
        static ulong[] array = new ulong[1024];
        static ulong FibonacciMemoization(uint n)
        {
            if (array[n] != ulong.MaxValue)
            {
                return array[n];
            }
            if (n==0 || n==1)
            {
                array[n] = n;
                return n;
            }
            array[n] = FibonacciMemoization(n - 1) + FibonacciMemoization(n - 2);
            return array[n];
        }
        static void Main()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ulong.MaxValue;
            }
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("The Fibbonacci {0} is {1}", n, FibonacciMemoization(n));
        }
    }
}
