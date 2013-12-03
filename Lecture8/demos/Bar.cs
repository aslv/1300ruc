using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture8Demos
{
    class Bar
    {
        public static void Main()
        {
            Person gosho = new Person("913412412", "Gosho");
            gosho.BeersLimit = 5;
            Person kolio = new Person("9212415135");
            kolio.BeersLimit = 10;
            for (int i = 0; i < 5; i++)
            {
                gosho.DrinkBeer();
                kolio.DrinkBeer();
            }
            gosho.DrinkBeer();
            gosho.Age = DateTime.Now.Year;
            kolio.Age = DateTime.Now.Year;
            Console.WriteLine(gosho.Age);
            Console.WriteLine(kolio.Age);
        }
    }
}
