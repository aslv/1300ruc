using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slavi_sDemos
{
    class IterationFromNToM
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("m = ");
            uint m = uint.Parse(Console.ReadLine());
            if (n > m)
            {
                n += m;
                m = n - m;
                n -= m;
            }
            ulong sum=0, k=0;
            for (uint i = n; i <= m; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
                k = i;
            }
            Console.WriteLine("\nsum = {0}", sum);
            Console.WriteLine("k={0}", k);
        }
    }
}
