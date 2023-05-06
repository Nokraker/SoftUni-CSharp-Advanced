using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int nLenght = nm[0];
            int mLenght = nm[1];

            HashSet<int> n = new HashSet<int>(nLenght);
            HashSet<int> m = new HashSet<int>(mLenght);

            for (int i = 0; i < nLenght; i++)
            {
                n.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < mLenght; i++)
            {
                m.Add(int.Parse(Console.ReadLine()));
            }

            List<int> nums = new List<int>();

            foreach (var num in n)
            {
                if (m.Contains(num))
                {
                    nums.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
