using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Georgi_sDemos
{
    class Task1
    {
        public static void Main()
        {
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine().Substring(0,5));
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input. Please input a number");
            }
            int originalNumber = number;
            int fifthDigit = number % 10;
            number = number / 10;
            int fourthDigit = number % 10;
            number = number / 10;
            int thirdDigit = number % 10;
            number = number / 10;
            int secondDigit = number % 10;
            number = number / 10;
            int firstDigit = number % 10;
            Console.WriteLine("reversed number: {0}{1}{2}{3}{4}",fifthDigit,fourthDigit,thirdDigit,secondDigit,firstDigit);
            Console.WriteLine((float)originalNumber / (firstDigit + secondDigit + thirdDigit + fourthDigit + fifthDigit));
        }
    }
}
