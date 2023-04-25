using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passesAllowed = int.Parse(Console.ReadLine());
            Queue<string> traffic = new Queue<string>();
            int passCount = 0;
            while (true)
            {
                string carOrGreen = Console.ReadLine();

                if (carOrGreen == "end")
                {
                    break;
                }

                if (carOrGreen != "green")
                {
                    traffic.Enqueue(carOrGreen);
                }
                else
                {
                    for (int i = 0; i < passesAllowed; i++)
                    {
                        if (traffic.Count > 0)
                        {
                            Console.WriteLine($"{traffic.Dequeue()} passed!");
                            passCount++;
                        }

                    }
                }
            }
            Console.WriteLine($"{passCount} cars passed the crossroads.");
        }
    }
}
