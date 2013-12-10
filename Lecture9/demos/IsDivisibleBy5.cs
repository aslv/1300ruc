using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackTrace1
{
    class IsDivisibleBy5
    {
        static bool IsDivisibleByDivisor(int dividend, int divisor)
        {
            return (dividend % divisor) == 0 ? true : false;
        }
        static int GetNumber()
        {
            return int.Parse(Console.ReadLine());
        }
        static void Main()
        {
            int divident, divisor = 5;
            try
            {
                divident = GetNumber();
            }
            catch (FormatException e)
            {
                Console.WriteLine("We require a number!");
                Console.WriteLine(e.StackTrace);
                divident = 100;
            }            
            if (IsDivisibleByDivisor(divident, divisor))
            {
                Console.WriteLine("Yeah, {0} is divisible by {1}.", divident, divisor);
            }
        }
    }
}
