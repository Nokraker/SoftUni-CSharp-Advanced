using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()
            );

            int rackCapacity = int.Parse(Console.ReadLine());

            int racks = 1;

            int valueSum = 0;

            while (clothes.Count > 0)
            {
                valueSum += clothes.Peek();

                if (valueSum <= rackCapacity)
                {
                    clothes.Pop();
                }
                else
                {
                    valueSum = clothes.Pop();
                    racks++;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
