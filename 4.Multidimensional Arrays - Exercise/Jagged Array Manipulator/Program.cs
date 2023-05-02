using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] inputNums = Console.ReadLine()?
                    .Split(" ");

                jagged[row] = new double[inputNums.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(inputNums[col]);
                }
            }

            //analyze
            for (int i = 0; i < jagged.Length - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                        jagged[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] /= 2;
                    }

                    jagged[i + 1] = jagged[i + 1]
                            .Select(x => x / 2)
                            .ToArray();
                }
            }

            //modify
            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "End")
                {
                    break;
                }
                else if (commands[0] == "Add")
                {
                    int row = int.Parse(commands[1]);
                    int column = int.Parse(commands[2]);
                    int value = int.Parse(commands[3]);

                    if (InputIsValid(row, column, jagged))
                    {
                        jagged[row][column] += value;
                    }
                }
                else if (commands[0] == "Subtract")
                {
                    int row = int.Parse(commands[1]);
                    int column = int.Parse(commands[2]);
                    int value = int.Parse(commands[3]);

                    if (InputIsValid(row, column, jagged))
                    {
                        jagged[row][column] -= value;
                    }
                }
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }

        private static bool InputIsValid(int row, int column, double[][] jagged)
        {
            if ((row >= 0 && row < jagged.Length) && (column >= 0 && column < jagged[row].Length))
            {
                return true;
            }

            return false;
        }
    }
}
