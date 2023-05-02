using System;
using System.Linq;

namespace Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D matrix size
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            //read matrix
            for (int i = 0; i < sizes[0]; i++)
            {
                int[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int maxSum = int.MinValue;

            int maxCol = 0;
            int maxRow = 0;

            //Find biggest 3x3 square sum
            for (int i = 1; i < sizes[0] - 1; i++)
            {
                for (int j = 1; j < sizes[1] - 1; j++)
                {
                    int sum = SqrSum(i, j, matrix);
                    if (sum > maxSum)
                    {
                        maxSum = sum;

                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Biggest3x3Matrix(maxRow, maxCol, matrix);
        }

        private static void Biggest3x3Matrix(int maxRow, int maxCol, int[,] matrix)
        {
            int i = maxRow;
            int j = maxCol;
            Console.WriteLine($"{matrix[i - 1, j - 1]} {matrix[i - 1, j]} {matrix[i - 1, j + 1]}");
            Console.WriteLine($"{matrix[i, j - 1]} {matrix[i, j]} {matrix[i, j + 1]}");
            Console.WriteLine($"{matrix[i + 1, j - 1]} {matrix[i + 1, j]} {matrix[i + 1, j + 1]}");
        }

        private static int SqrSum(int i, int j, int[,] matrix)
        {

            return matrix[i - 1, j - 1] + matrix[i - 1, j] + matrix[i - 1, j + 1] +
                    matrix[i, j - 1] + matrix[i, j] + matrix[i, j + 1] +
                    matrix[i + 1, j - 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
        }
    }
}
