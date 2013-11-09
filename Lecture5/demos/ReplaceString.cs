using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    class ReplaceString
    {
        public static void Main()
        {
            //Replace greeting
            string japaneseGreeting = "Herro this is coor";
            string normalGreeting = japaneseGreeting.Replace('r', 'l');
            Console.WriteLine(normalGreeting);

            string result=RemoveName("Hello I'm Gosho");
            Console.WriteLine(result);
        }

        public static string RemoveName(string greetingWithName)
        {            
            string greetingWithoutName = greetingWithName.Remove(greetingWithName.IndexOf("G"));
            return greetingWithoutName;
        }
    }
}
