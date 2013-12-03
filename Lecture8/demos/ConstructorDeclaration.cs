using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture8Demos
{
    class Cat
    {
        private string name;
        private int age;
        private double length;

        public Cat()
        {
            //this.age = 1;
        }

        //public Cat(string name) : this(name, 1, 10.1)
        //{
        //}

        //public Cat(string name, int age, double length)
        //{
        //    this.name = name + "102";
        //    this.age = age;
        //    this.length = length;
        //}

        public void PrintStatus()
        {
            Console.WriteLine("Hallo! My name is {0}, I'm {1} years old and {2} cm long", this.name, this.age, this.length);
        }
    }
    class ConstructorDeclaration
    {
        public static void Main()
        {
            //Cat pissanka = new Cat("Pissanka", 1, 15);
            //pissanka.PrintStatus();
            //Cat kathy = new Cat("Kathy");
            //kathy.PrintStatus();
            Cat prostho = new Cat();
            prostho.PrintStatus();
        }
    }
}
