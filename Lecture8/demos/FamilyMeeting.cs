using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemos
{
    class FamilyMeeting
    {
        public static void Main()
        {
            //Set age for the first child
            Console.WriteLine("How old is the first child");
            int firstChildAge = int.Parse(Console.ReadLine());
            //Set age for the second child
            Console.WriteLine("How old is the second child");
            int secondChildAge = int.Parse(Console.ReadLine());

            Child firstChild = new Child(firstChildAge);
            Child secondChild = new Child();
            secondChild.Age = secondChildAge;
            Child[] children = { firstChild, secondChild };

            //Aunt comes along
            foreach (var child in children)
            {
                child.TellAge();
            }
        }
    }
}
