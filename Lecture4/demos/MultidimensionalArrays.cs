using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class MultidimensionalArrays
    {
        public static void Main()
        {
            int[,] matrix =
            {
              {1, 3, 5, 7, 9}, 
              {0, 2, 4, 6, 8},
            };

            //Print the matrix using for.
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]+" ");
                }
                Console.WriteLine();
            }
            //Print the matrix using foreach.
            //foreach (var item in matrix)
            //{
            //    Console.Write(item+" ");
            //}
        }
    }
}
