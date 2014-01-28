using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeDemos
{
    class MainProgram
    {
        static void Main()
        {
            Tree<int> tree = null;
            try
            {
                tree =
                    new Tree<int>(7,
                        new Tree<int>(19,
                            new Tree<int>(1),
                            new Tree<int>(12),
                            new Tree<int>(31)),
                        new Tree<int>(21),
                        new Tree<int>(14,
                            new Tree<int>(23),
                            new Tree<int>(6))
                    );
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Something went wrong :(\n{0}", e.Message);
            }
            finally
            {
                tree.PrintDFS();
            }
        }
    }
}
