using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maths.AlgebricMethods;

namespace reading
{
    class IncludingNamespaces
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int result;
            result = PowerClass.Power(number, power);
            Console.WriteLine("{0} to the power of {1} is {2}", number, power, result);
        }
    }
}
