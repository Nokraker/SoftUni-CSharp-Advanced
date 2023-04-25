using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> output = new Stack<char>();
            for(int i = 0; i < input.Length; i++) 
            {
                output.Push(input[i]);
            }
            Console.WriteLine(String.Join("",output));
        }
    }
}
