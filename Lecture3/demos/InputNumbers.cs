using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    
    class InputNumbers
    {
        static void Main()
        {
            int number = 0;
            int count = 0;
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    Console.WriteLine("You didn't input a number");
                    break;
                }
                Console.WriteLine("Your number is {0}",number);
            }
            Console.WriteLine("Successful inputs = {0}",count);

        }
    }
}
