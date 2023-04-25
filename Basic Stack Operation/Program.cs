using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberOfnums = tokens[0];
            int numbersToRemove = tokens[1];
            int neddedNum = tokens[2];

            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(array);

            for (int i = 0; i < numbersToRemove; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(neddedNum))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
