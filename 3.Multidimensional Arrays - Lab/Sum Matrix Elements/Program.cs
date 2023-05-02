using System;
using System.Linq;

namespace Sum_Matrix_Elements
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

            Console.WriteLine(sizes[0]);
            Console.WriteLine(sizes[1]);

            int sum = 0;

            foreach (var item in matrix)
            {
                sum += item;
            }

            Console.WriteLine(sum);
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
