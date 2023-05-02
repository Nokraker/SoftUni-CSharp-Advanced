using System;
using System.Linq;

namespace Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                string[] row = Console.ReadLine()
                    .Split(" ");

                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int sqrOfEqCells = 0;

            for (int i = 0; i < sizes[0] - 1; i++)
            {
                for (int j = 0; j < sizes[1] - 1; j++)
                {
                    if (equalSqrCells(i, j, matrix))
                    {
                        sqrOfEqCells++;
                    }
                }
            }

            Console.WriteLine(sqrOfEqCells);
        }

        private static bool equalSqrCells(int i, int j, string[,] matrix)
        {
            if (
                matrix[i, j] == matrix[i + 1, j] &&
                matrix[i, j] == matrix[i, j + 1] &&
                matrix[i, j] == matrix[i + 1, j + 1])
            {
                return true;
            }

            return false;
        }
    }
}
