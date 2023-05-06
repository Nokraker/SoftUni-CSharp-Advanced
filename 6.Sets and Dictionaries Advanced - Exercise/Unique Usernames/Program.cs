using System;
using System.Collections.Generic;
using System.Linq;


namespace Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());

            }

            names = names.Distinct().ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
