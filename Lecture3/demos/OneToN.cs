using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class OneToN
    {
        public static void Main()
        {
            int counter = 1;
            int sum = 0;
            int n = 0;

            Console.WriteLine("Enter n:");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("This is not a valid number");
                return;
            }
            while (counter <= n)
            {
                Console.WriteLine(counter);
                sum += counter;
                counter++;
            }
            Console.WriteLine("The sum is {0}", sum);
            Console.WriteLine("The result of division is {0}",(float)sum/n);
        }
    }
}
