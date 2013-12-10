using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionsOverview
{
    class Program
    {
        private void DeliverToner()
        {
            throw new FlatTireException("We hit a hedgehog");
        }
        private void PutTonerInPrinter()
        {
            try
            {
                DeliverToner();
            }
            catch (FlatTireException e)
            {

                throw new NoTonerException("The truck didn't arrive",e);
            }
        }
        private void PrintSomething()
        {
            PutTonerInPrinter();
        }
        static void Main(string[] args)
        {
            Program slavi = new Program();
            try
            {
                slavi.PrintSomething();
            }
            catch (NoTonerException e)
            {
                using (StreamWriter writer=new StreamWriter("log.txt"))
                {
                    writer.WriteLine(e.StackTrace);
                }
                throw;
            }
        }
    }
}
