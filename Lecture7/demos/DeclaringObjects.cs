using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reading
{
    class DeclaringObjects
    {
        public static void Main()
        {
            System.Diagnostics.Stopwatch watch=new System.Diagnostics.Stopwatch();
            System.Diagnostics.Stopwatch watch2 = watch;
            Console.WriteLine(watch2.Elapsed);
        }
    }
}
