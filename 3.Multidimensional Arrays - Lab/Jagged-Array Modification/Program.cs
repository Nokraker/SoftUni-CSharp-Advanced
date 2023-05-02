using System;

namespace Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int row = 0; row < n; row++)
            {
                string[] inputNums = Console.ReadLine()?
                    .Split(" ");

                jagged[row] = new int[inputNums.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(inputNums[col]);
                }
            }

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split();

                if (commands[0] == "END")
                {
                    break;
                }

                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);

                if (row < 0 || row >= n || col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                else if (commands[0] == "Add")
                {
                    jagged[row][col] += int.Parse(commands[3]);
                }
                else if (commands[0] == "Subtract")
                {
                    jagged[row][col] -= int.Parse(commands[3]);
                }
            }

            foreach (var array in jagged)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
