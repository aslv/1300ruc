using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class BooleanOperators
    {
        static void Main()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!b);
            Console.WriteLine(b || true);
            Console.WriteLine((0 > 42) ^ (a == b));
        }
    }
}
