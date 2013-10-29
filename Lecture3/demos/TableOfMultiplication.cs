using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slavi_sDemos
{
    class TableOfMultiplication
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
