using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>(names);

            int rotations = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i < rotations; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
