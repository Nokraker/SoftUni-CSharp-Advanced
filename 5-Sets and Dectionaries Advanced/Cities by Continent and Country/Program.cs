using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var locatons = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = commands[0];
                string country = commands[1];
                string city = commands[2];

                if (!locatons.ContainsKey(continent))
                {
                    locatons.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!locatons[continent].ContainsKey(country))
                {
                    locatons[continent].Add(country, new List<string>());
                }

                locatons[continent][country].Add(city);

            }

            foreach (var continent in locatons)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
