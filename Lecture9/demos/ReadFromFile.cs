using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StackTrace2
{
    class ReadFromFile
    {
        static string GetTextFromFile(string fileName)
        {
            TextReader reader;
            string result;
            try
            {
                reader = new StreamReader(fileName);
                result = reader.ReadToEnd();
            }
            catch (FileNotFoundException e)
            {
                throw new ArgumentException("The file provided cannot be found!", e);
            }
            reader.Close();
            return result;
        }
        static void Main()
        {
            string content = "";
            string fileName = "iyOYhoHOUIHhIGIUKGIUOhguigikOIHIUglYFiuugilgluj.txt";
            //try
            //{
            //    content = GetTextFromFile(fileName);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.InnerException);
            //}

            content = GetTextFromFile(fileName);
            Console.WriteLine(content);
        }
    }
}
