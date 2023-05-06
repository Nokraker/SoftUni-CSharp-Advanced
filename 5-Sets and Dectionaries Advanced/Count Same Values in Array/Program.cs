using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToArray();


            Dictionary<double, int> counter = new Dictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!counter.ContainsKey(num))
                {
                    counter.Add(num, 0);
                }
                counter[num]++;
            }

            foreach (var key in counter)
            {
                Console.WriteLine($"{key.Key} - {key.Value} times");
            }
        }
    }
}
