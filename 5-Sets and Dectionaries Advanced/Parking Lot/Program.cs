using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> plates = new HashSet<string>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commands = command
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "IN")
                {
                    plates.Add(commands[1]);
                }
                else
                {
                    plates.Remove(commands[1]);
                }
            }

            if (plates.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }

            foreach (var item in plates)
            {
                Console.WriteLine(item);
            }
        }
    }
}
