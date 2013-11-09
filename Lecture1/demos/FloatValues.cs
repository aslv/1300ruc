using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class FloatValues
    {
        static void Main(string[] args)
        {
            double a = 0.1f;
            Console.WriteLine("Error in doubles? {0:N25}",10*a);

            float b = 0.1f;
            Console.WriteLine("Error in floats? {0:N25}",b+b+b+b+b);
        }
    }
}
