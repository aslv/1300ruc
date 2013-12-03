using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture8Demos
{
    class Dog
    {
        private static int count;

        public static int Count
        {
            get { return Dog.count; }
            set { Dog.count = value; }
        }
        private string name;

        static Dog()
        {
            Console.WriteLine("Static constructor!");
            Dog.count = 0;
        }

        public Dog(string name)
        {
            this.name = name;
            Dog.count++;
        }
        ~Dog()
        {
            Dog.count--;
        }

        public static int WeAreLegion() // inappropriate name!
        {
            return Dog.count;
        }
        
        public string SayName()
        {
            return this.name;
        }
    }
    class StaticMembersUsage
    {
        public static void Main()
        {
            Dog.Count++;
            Console.WriteLine("-----------");
            Dog sharo = new Dog("Sharo");
            Console.WriteLine(sharo.SayName());
            Dog pesho = new Dog("Pesho");
            Console.WriteLine("{0}", Dog.WeAreLegion());
        }
    }
}
