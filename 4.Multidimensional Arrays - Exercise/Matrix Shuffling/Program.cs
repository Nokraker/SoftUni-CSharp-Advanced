using System;
using System.Linq;

namespace Matrix_Shuffling
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

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split();

                if (commands[0] == "END")
                {
                    break;
                }

                if (InputIsValid(commands, matrix))
                {
                    int row1 = int.Parse(commands[1]);
                    int col1 = int.Parse(commands[2]);
                    int row2 = int.Parse(commands[3]);
                    int col2 = int.Parse(commands[4]);

                    int temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;

                    PrintMatrix(matrix);

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool InputIsValid(string[] commands, int[,] matrix)
        {
            if (commands.Length != 5 || commands[0] != "swap")
            {
                return false;
            }

            int row1 = int.Parse(commands[1]);
            int col1 = int.Parse(commands[2]);
            int row2 = int.Parse(commands[3]);
            int col2 = int.Parse(commands[4]);
            if (row1 < 0 || row1 >= matrix.GetLength(0) || row2 < 0 || row2 >= matrix.GetLength(0))
            {
                return false;
            }

            if (col1 < 0 || col1 >= matrix.GetLength(1) || col2 < 0 || col2 >= matrix.GetLength(1))
            {
                return false;
            }


            return true;
        }
    }
}
