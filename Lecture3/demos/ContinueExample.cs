using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slavi_sDemos
{
    class ContinueExample
    {
        static void Main()
        {
            int inputNumber = 0;
            //for (; inputNumber >= 0; )
            //{
            //    inputNumber = int.Parse(Console.ReadLine());
            //    if (inputNumber == 13)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("Input number: {0}", inputNumber);
            //}
            for (; inputNumber >= 0; )
            {
                inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber < 0)
                {
                    continue;
                }
                Console.WriteLine("Sqrt of {0} is {1}", inputNumber, Math.Sqrt(inputNumber));
            }
        }

    }
}
