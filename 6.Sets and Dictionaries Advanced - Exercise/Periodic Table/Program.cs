using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> chem = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                foreach (var element in elements)
                {
                    chem.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", chem));
        }
    }
}
