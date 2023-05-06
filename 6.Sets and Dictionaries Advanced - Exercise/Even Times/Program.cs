using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (counter.ContainsKey(num) == false)
                {
                    counter.Add(num, 0);
                }

                counter[num]++;

            }

            counter = counter
                .Where(x => x.Value % 2 == 0)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in counter)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
