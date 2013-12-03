using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Demos
{
    class Person
    {
        private string id;
        private int age;
        private string name;
        private bool drunk=false;
        private int beersDrank=0;
        private int beersLimit;

        public int BeersLimit
        {
            get { return beersLimit; }
            set { beersLimit = value; }
        }

        public Person(string id)
        {
            this.id = id;
            name = "Kolio";
        }

        public Person(string id, string name)
        {
            this.id=id;
            this.name = name;
        }

        private void SetId(string id)
        {
            //this method validates all the numbers of the ID
            //and sets the ID if they are valid
            //else it throws an exception
        }

        

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Can't be unborn");
                }
                string birthYearShort = id.Substring(0, 2);
                if (birthYearShort[0].Equals("0"))
                {
                    birthYearShort = "20"+birthYearShort;
                }
                else
                {
                    birthYearShort = "19" + birthYearShort;
                }
                int birthYearLong = int.Parse(birthYearShort);
                age = value - birthYearLong;
            }
        }

        public string Id
        {
            get {return id;}
        }

        public void DrinkBeer()
        {
            if (isDrunk())
            {
                Console.WriteLine("You're drunk go home");
            }
            else
            {
                beersDrank++;
                Console.WriteLine("Hey {0} just drank a beer", name);
            }
        }

        private bool isDrunk()
        {
            if (beersDrank < beersLimit)
            {
                return false;
            }
            return true;
        }

    }
}
