using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace reading
{
    class AccessingMethods
    {
        private int id;
        private string name;
        public AccessingMethods(int id)
        {
            this.id = id;
        }
        public AccessingMethods(int id,string name)
        {

        }
        public static void Main()
        {
            DateTime currentDate = new DateTime();
            for (int i = 0; i < 61; i++)
            {
                currentDate= currentDate.AddSeconds(1);
                Thread.Sleep(1000);
                Console.WriteLine(currentDate.ToString());
            }
        }
    }
}
