using System;
using System.Collections.Generic;

namespace Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parantheses = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            bool a = false;
            bool b = false;
            bool c = false;

            for (int i = 0; i < parantheses.Length; i++)
            {
                if (parantheses[i] == '{' ||
                   parantheses[i] == '(' ||
                   parantheses[i] == '[')
                {
                    stack.Push(parantheses[i]);
                }

                if (stack.Count > 0)
                {
                    if (parantheses[i] == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }

                    if (parantheses[i] == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }


                    if (parantheses[i] == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
