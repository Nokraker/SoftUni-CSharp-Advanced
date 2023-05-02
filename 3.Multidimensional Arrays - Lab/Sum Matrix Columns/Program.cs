using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int rows = 0; rows < sizes[0]; rows++)
            {

                int[] arr = ReadArrayFromConsole();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[rows, col] = arr[col];
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int colSum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    colSum += matrix[j, i];
                }
                Console.WriteLine(colSum);
            }
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
