using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class ForAndForeach
    {
        //Double the elements from the array.
        public static void Main()
        {
            int[] arr = { 2, 4, 8, 16, 32 };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
