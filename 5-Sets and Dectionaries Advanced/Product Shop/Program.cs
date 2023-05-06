using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var catalouge = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Revision")
                {
                    break;
                }

                if (!catalouge.ContainsKey(commands[0]))
                {
                    catalouge[commands[0]] = new Dictionary<string, double>();

                }

                catalouge[commands[0]][commands[1]] = double.Parse(commands[2]);

            }


            foreach (var supermarket in catalouge)
            {
                Console.WriteLine($"{supermarket.Key}->");

                foreach (var product in supermarket.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
