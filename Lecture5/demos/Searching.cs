using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    class Searching
    {
        static void Main()
        {
            string stupid = "Give me a sentance please";
            char letter = 'e';
            int index=0;
            index = stupid.IndexOf(letter);
            while (index != -1)
            {
                Console.WriteLine("{0} found in position {1}",letter,index);
                index = stupid.IndexOf(letter, index + 1);
            }
        }
    }
}
