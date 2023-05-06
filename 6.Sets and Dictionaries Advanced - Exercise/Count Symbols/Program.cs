using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> counter = new SortedDictionary<char, int>();

            char[] text = Console.ReadLine()
                .ToCharArray();

            foreach (var chr in text)
            {
                if (!counter.ContainsKey(chr))
                {
                    counter.Add(chr, 0);
                }

                counter[chr]++;
            }

            foreach (var chr in counter)
            {
                Console.WriteLine($"{chr.Key}: {chr.Value} time/s");
            }
        }
    }
}
