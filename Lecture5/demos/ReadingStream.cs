using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Streams
{
    class ReadingStream
    {
        static string ivan = "ivan";
        static void Main()
        {
            StreamReader reader = new StreamReader("data.csv");
            int lineNumber = 0;
            string line=reader.ReadLine();
            string separator = line.Substring(line.IndexOf("=")+1);
            string[] items;
            while (true)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                items=line.Split(separator.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("Hello my name {0} my profession is {1} and I'm {2} years old", items[0], items[1],items[2]);
                lineNumber++;
            }
            reader.Close();
            ivan = "onq";
        }
    }
}
