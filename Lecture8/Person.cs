using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemos
{
    class Person
    {
        string id;
        int age;
        string name;

        Person(string id)
        {
            this.id=id;
            name = "Kolio";
        }

        Person(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        int Age
        {
            get { return age; }
            set { age = value; }
        }

        string Id
        {
            get { return id; }
            set { id = value; }
        }

        void DrinkBeer()
        {
            Console.WriteLine("Hey {0} just drank a beer",name);
        }

    }
}
