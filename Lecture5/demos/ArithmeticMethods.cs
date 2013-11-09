using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    class ArithmeticMethods
    {
        static void Main(string[] args)
        {
            double result = Sum(2,3);
            Console.WriteLine(result);
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Sums the two doubles
        /// </summary>
        /// <param name="a">First double number</param>
        /// <param name="b">Second double nuber</param>
        /// <returns></returns>
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// Sums all the arguements in the line
        /// </summary>
        /// <param name="line">this is a description</param>
        /// <returns></returns>
        public static double Sum(string line)
        {
            string[] items = line.Split('+');
            int number ;
            double sum = 0;
            foreach (var item in items)
            {
                int.TryParse(item, out number);
                sum += number;
            }
            return sum;
        }
    }
}
