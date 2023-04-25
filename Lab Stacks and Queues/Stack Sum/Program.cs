using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < list.Count; i++)
            {
                stack.Push(list[i]);
            }

            while (true) 
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();

                if (commands[0].ToLower() == "end") break;

                if (commands[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(commands[1]));
                    stack.Push(int.Parse(commands[2]));
                }
                else if (commands[0].ToLower() == "remove")
                {
                    if(stack.Count < int.Parse(commands[1])) 
                    {
                        continue;
                    }
                    else
                    {
                        for(int i = 0; i < int.Parse(commands[1]); i++) 
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
