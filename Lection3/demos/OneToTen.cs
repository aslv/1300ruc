using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class OneToTen
    {
        public static void Main()
        {
            byte counter = 10;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (false);
        }
    }
}
