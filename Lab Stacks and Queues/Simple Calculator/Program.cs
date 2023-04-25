using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> stackInput = new Stack<string>(input);

            while (stackInput.Count > 1)
            {
                int a = int.Parse(stackInput.Pop());
                string op = stackInput.Pop();
                int b = int.Parse(stackInput.Pop());

                if (op == "+")
                {
                    stackInput.Push((a + b).ToString());
                }
                else if (op == "-")
                {
                    stackInput.Push((a - b).ToString());
                }
            }

            Console.WriteLine(stackInput.Pop());
        }
    }
}
