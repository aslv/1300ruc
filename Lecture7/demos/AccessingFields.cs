using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reading
{
    class AccessingFields
    {
        static int nula = 0;
        public static void Main()
        {
            AccessingFields fields = new AccessingFields();
            DateTime date = DateTime.Now;
            Console.WriteLine(date.Year); 
        }
    }
}
