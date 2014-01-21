using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class ListTDemo
    {
        /*static void Main(string[] args)
        {
            List<int> primes = GeElems3(200, 300);
            foreach (var item in primes)
            {
                Console.WriteLine("{0} ", item);
            }
            Console.Read();
        }*/
        /// <summary>
        /// Get the elements multiple of 3 in a specified range.
        /// </summary>
        /// <param name="start"> Starting with </param>
        /// <param name="end"> Ending with</param>
        /// <returns>A list of the required numbers.</returns>
        public static List<int> GeElems3(int start, int end)
        {
            List<int> list = new List<int>();
            for (int num = start; num <= end; num++)
            {

                if (num % 3 == 0)
                {
                    list.Add(num);
                }
            }
            return list;
        }
    }
}
