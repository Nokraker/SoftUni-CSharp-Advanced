using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            Queue<int> orderQueue = new Queue<int>(
                 Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()
            );

            Console.WriteLine(orderQueue.Max());


            int servedFood = 0;
            while (orderQueue.Count > 0)
            {
                servedFood += orderQueue.Peek();

                if (servedFood <= quantity)
                {
                    orderQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', orderQueue)}");
                    return;
                }

            }

            Console.WriteLine("Orders complete");
        }
    }
}
