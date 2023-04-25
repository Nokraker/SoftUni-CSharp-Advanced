using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            expression.Reverse();


            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int leftBracketIdx = indexes.Pop();
                    int rightBracketIdx = i;

                    Console.WriteLine(expression.Substring(leftBracketIdx, rightBracketIdx - leftBracketIdx + 1));
                }
            }
        }
    }
}
