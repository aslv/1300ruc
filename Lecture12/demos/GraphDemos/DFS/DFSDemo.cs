using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFS
{
    class DFSDemo
    {
        static int n;
        static int[,] a;
        static bool[] used;

        static void DFS(int i)
        {
            Stack<int> s = new Stack<int>();
            int current;
            s.Push(i);
            used[i] = true;
            while (s.Count > 0)
            {
                current = s.Pop();
                Console.Write("{0} ", current + 1);
                for (int j = n-1; j >= 0; j--)
                {
                    if (a[current, j] == 1 && !used[j])
                    {
                        s.Push(j);
                        used[j] = true;
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            Console.Write("Enter the numbers of vertices: ");
            n = int.Parse(Console.ReadLine());
            a = new int[n, n];
            used = new bool[n];
            Console.Write("Enter the numbers of ribs: ");
            int numberOfRibs = int.Parse(Console.ReadLine());
            int u, v;
            string[] s;
            Console.WriteLine("Enter vertex couples:");
            for (int i = 0; i < numberOfRibs; i++)
            {
                s = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                u = int.Parse(s[0]);
                v = int.Parse(s[1]);
                a[u - 1, v - 1] = 1;
                a[v - 1, u - 1] = 1; // for undirected graph
            }
            Console.Write("Enter a vertex to start with: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Start from {0}", start);
            DFS(start - 1);
        }
    }
}
