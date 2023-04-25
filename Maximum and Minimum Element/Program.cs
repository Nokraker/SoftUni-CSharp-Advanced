using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();

                if (commands[0] == "1")
                {
                    int pushNumber = int.Parse(commands[1]);
                    numbers.Push(pushNumber);
                }
                else if (commands[0] == "2")
                {
                    numbers.Pop();
                }
                else if (commands[0] == "3")
                {
                    if (numbers.Count == 0) continue;
                    else
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (commands[0] == "4")
                {
                    if (numbers.Count == 0) continue;
                    else
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers.ToArray()));
        }
    }
}
