using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maths
{
    namespace AlgebricMethods
    {
        class PowerClass
        {
            public static int Power(int number, int power)
            {
                int result;
                result = (int)Math.Pow(number, power);
                return result;
            }
        }
    }
    
}
