using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class AritmethicOperators
    {
        static void Main()
        {
            int a = 3;
            int b = 5;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            //Console.WriteLine(a + b++);
            //Console.WriteLine(b - --a);//Difference? Why?
            Console.WriteLine(a * b);
            Console.WriteLine(b / a);//Wrong?
            Console.WriteLine(b % a);
        }
    }
}
