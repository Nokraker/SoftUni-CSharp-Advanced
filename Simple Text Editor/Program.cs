using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            Stack<string> undo = new Stack<string>();

            undo.Push(sb.ToString());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "1")
                {
                    undo.Push(sb.Append(tokens[1]).ToString());
                }
                else if (command == "2")
                {
                    int count = int.Parse(tokens[1]);
                    int startIndex = sb.Length - count;
                    sb.Remove(startIndex, count);
                    undo.Push(sb.ToString());
                }
                else if (command == "3")
                {
                    int index = int.Parse(tokens[1]) - 1;
                    Console.WriteLine(sb[index]);
                }
                else
                {
                    undo.Pop();
                    sb = new StringBuilder();
                    sb.Append(undo.Peek());
                }
            }
        }
    }
}
