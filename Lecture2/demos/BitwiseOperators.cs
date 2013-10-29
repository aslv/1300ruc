using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class BitwiseOperators
    {
        static void Main()
        {
            byte a = 9;                  //0000 1001
            byte b = 10;                 //0000 1010

            Console.WriteLine(a | b);     //0000 1011
            Console.WriteLine(a & b);     //0000 1000
            Console.WriteLine(a ^ b);     //0000 0011
            Console.WriteLine(~a & b);    //0000 0001
            Console.WriteLine(a<<3);      //0100 1000
            Console.WriteLine(b>>2);      //0000 0010
        }
    }
}
