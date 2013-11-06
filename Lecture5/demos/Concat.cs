using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Strings
{
    class Concat
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            int length = 25000;
            string result = "";
            StringBuilder sb = new StringBuilder("Hello I' kolio");
            sb.Insert(8, "m");
            watch.Start();
            //for (int i = 0; i < length; i++)
            //{
            //    result += i;
            //}
            //for (int i = 0; i < length; i++)
            //{
            //    sb.Append(i);
            //}
            result = sb.ToString();
            watch.Stop();
            Console.WriteLine(result);
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
