using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slavi_sDemos
{
    class ForeachExample
    {
        static void Main()
        {
            //string[] citites = new string[] { "Sofia", "Melnik", "Shumen", "Ruse", "Ahtopol", "New York" };
            string cityName = "Rousse";
            foreach (char letter in cityName)
            {
                Console.WriteLine("Now the value of \"letter\" is {0}.", letter);
            }
        }
    }
}
