using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture8Demos
{
    class Squirrel
    {
        private int age;
        private double tailLenght;

        public void SetStatus(int age, int tailLen)
        {
            this.age = age;
            this.tailLenght = tailLen;
        }
        public void PrintStatus()
        {
            Console.WriteLine("Hello! I'm {0} years old and my tail is {1} cm long.", age, tailLenght);
        }
    }
    class ThisDemo
    {
        static void Main()
        {
            Squirrel Katty = new Squirrel();
            Katty.SetStatus(2, 30);
            Katty.PrintStatus();
        }
    }
}
