using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int rows = 0; rows < sizes[0]; rows++)
            {
                int[] arr = ReadArrayFromConsole();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[rows, col] = arr[col];
                }
            }

            int biggestSum = int.MinValue;
            int biggestRowIndex = 0;
            int biggestColmnIndex = 0;


            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int currentBlockSum = matrix[i, j] + matrix[i + 1, j] +
                                   matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if (currentBlockSum > biggestSum)
                    {
                        biggestColmnIndex = i;
                        biggestRowIndex = j;
                        biggestSum = currentBlockSum;
                    }
                }
            }

            Console.WriteLine($"{matrix[biggestColmnIndex, biggestRowIndex]} {matrix[biggestColmnIndex, biggestRowIndex + 1]}");
            Console.WriteLine($"{matrix[biggestColmnIndex + 1, biggestRowIndex]} {matrix[biggestColmnIndex + 1, biggestRowIndex + 1]}");
            Console.WriteLine(biggestSum);
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
