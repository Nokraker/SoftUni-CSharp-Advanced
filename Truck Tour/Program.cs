using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Queue<int[]> circle = new Queue<int[]>();

            for (int i = 0; i < N; i++)
            {
                int[] petrol = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                circle.Enqueue(petrol);
            }

            int index = 0;

            while (true)
            {
                int totalFueal = 0;
                foreach (var petrolPump in circle)
                {
                    int petrolAmount = petrolPump[0];
                    int distance = petrolPump[1];
                    totalFueal += petrolAmount - distance;
                    if (totalFueal < 0)
                    {
                        circle.Enqueue(circle.Dequeue());
                        index++;
                        break;
                    }
                }
                if (totalFueal >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
