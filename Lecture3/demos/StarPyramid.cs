using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slavi_sDemos
{
    class StarPyramid
    {
        static void Main()
        {
            int numberOfStars = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= numberOfStars; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
