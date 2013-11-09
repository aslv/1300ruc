using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursion
{
    class Iteration
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
