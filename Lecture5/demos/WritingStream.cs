using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Streams
{
    class WritingStream
    {
        static void Main()
        {
            string currentLine;
            try
            {
                StreamWriter writer = new StreamWriter("lines.txt");
                using (writer)
                {
                    do
                    {
                        currentLine = Console.ReadLine();
                        if (currentLine.Equals("END"))
                        {
                            break;
                        }
                        writer.WriteLine(currentLine);
                    }
                    while (true);
                }
                //writer.WriteLine("Error line!!!!!!!!");
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("404");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Some error(s) ocuured.");
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Some AWFUL error(s) ocuured.");
            }
        }
    }
}
