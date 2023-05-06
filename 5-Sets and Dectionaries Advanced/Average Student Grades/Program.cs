using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradeCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < gradeCount; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (grades.ContainsKey(commands[0]))
                {
                    grades[commands[0]].Add(decimal.Parse(commands[1]));
                }
                else
                {
                    grades.Add(commands[0], new List<decimal>()
                    {
                        decimal.Parse(commands[1])
                    });
                }
            }

            foreach (var kvp in grades)
            {
                string gradeOfStudent = string.Join(" ", kvp.Value.Select(x => x.ToString("F2")));
                Console.WriteLine($"{kvp.Key} -> {gradeOfStudent} (avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
