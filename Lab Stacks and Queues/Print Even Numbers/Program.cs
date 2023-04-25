using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> even = new Queue<int>(nums);

            int count = even.Count;

            for (int i = 0; i < count; i++)
            {
                if (even.Peek() % 2 == 0)
                {
                    even.Enqueue(even.Dequeue());
                }
                else
                {
                    even.Dequeue();
                }

            }
            Console.WriteLine(string.Join(", ", even));
        }
    }
}
