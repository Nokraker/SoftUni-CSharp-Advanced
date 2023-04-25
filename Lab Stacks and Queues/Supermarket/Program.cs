using System;
using System.Collections.Generic;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                if (command != "Paid")
                {
                    customers.Enqueue(command);
                }
                else
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine($"{customers.Dequeue()}");
                    }
                    customers.Clear();
                }
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
