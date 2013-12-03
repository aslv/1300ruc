using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemos
{
    public class Child
    {
        //Define field
        private int age;

        //Define property over the field age
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        //Define constructor
        public Child()
        {
            this.age = 0;
        }

        //Define another constructor
        public Child(int age)
        {
            this.age = age;
        }

        //Dog's default behaviour
        public void TellAge()
        {
            Console.WriteLine("I'm {0} years old",age);
        }

    }
}
