using System;
using System.Linq;

namespace Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int firstDioagonal = 0;
            int secondDiagonal = 0;

            for (int row = 0; row < n; row++)
            {

                int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = arr[col];

                    if (row == col)
                    {
                        firstDioagonal += matrix[row, col];
                    }

                    if (row + col == matrix.GetLength(0) - 1)
                    {
                        secondDiagonal += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(Math.Abs(firstDioagonal - secondDiagonal));
        }
    }
}
