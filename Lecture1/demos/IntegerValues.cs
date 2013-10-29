using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class IntegerValues
    {
        static void Main(string[] args)
        {
            //Signed byte values
            Console.WriteLine("signed byte values");
            sbyte sbyteA = SByte.MaxValue;
            Console.WriteLine(sbyteA);
            sbyteA = SByte.MinValue;
            Console.WriteLine(sbyteA);
            //unsigned byte values
            Console.WriteLine("unsigned byte values");
            byte byteA = Byte.MaxValue;
            Console.WriteLine(byteA);
            byteA = Byte.MinValue;
            Console.WriteLine(byteA);
            //Short values
            Console.WriteLine("short values");
            short shortA = short.MaxValue;
            Console.WriteLine(shortA);
            shortA = short.MinValue;
            Console.WriteLine(shortA);
            //int values
            Console.WriteLine("int values");
            int intA = Int32.MaxValue;
            Console.WriteLine(intA);
            intA = Int32.MinValue;
            Console.WriteLine(intA);
            //long values
            Console.WriteLine("long values");
            long longA = long.MaxValue;
            Console.WriteLine(longA);
            longA = long.MinValue;
            Console.WriteLine(longA);
        }
    }
}
