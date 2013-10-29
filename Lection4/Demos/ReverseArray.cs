using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class ReverseArray
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            // Get array size
            int length = array.Length;
            // Declare and create the reversed array
            int[] reversed = new int[length];

            // Initialize the reversed array
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }

            // Print the reversed array
            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index] + " ");
            }
        }
        #region Better way
        //static void Main()
        //{
        //    int[] array = { 1, 2, 3, 4, 5 };
        //    int buff;
        //    int length = array.Length;

        //    for (int i = 0; i < length/2; i++)
        //    {
        //        buff = array[i];
        //        array[i]= array[length-i-1];
        //        array[length - i - 1] = buff;
        //    }
        //    for (int i = 0; i < length; i++)
        //    {
        //        Console.WriteLine(array[i]);
        //    }
        //}
        #endregion
    }
}
