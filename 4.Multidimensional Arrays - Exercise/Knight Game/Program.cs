using System;

namespace Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {

                char[] arr = Console.ReadLine()
                    .ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int removedKnights = 0;

            while (true)
            {
                int knightRow = -1;
                int knightCol = -1;
                int maxAttack = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int temAttack = CountAttacks(matrix, row, col);

                            if (temAttack > maxAttack)
                            {
                                maxAttack = temAttack;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }

                if (maxAttack > 0)
                {
                    matrix[knightRow, knightCol] = '0';
                    removedKnights++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(removedKnights);
        }

        static int CountAttacks(char[,] matrix, int row, int col)
        {
            int attack = 0;

            if (IsInMatrix(row + 1, col - 2, matrix.GetLength(0)) && matrix[row + 1, col - 2] == 'K')
            {
                attack++;
            }

            if (IsInMatrix(row - 1, col - 2, matrix.GetLength(0)) && matrix[row - 1, col - 2] == 'K')
            {
                attack++;
            }

            if (IsInMatrix(row + 1, col + 2, matrix.GetLength(0)) && matrix[row + 1, col + 2] == 'K')
            {
                attack++;
            }

            if (IsInMatrix(row - 1, col + 2, matrix.GetLength(0)) && matrix[row - 1, col + 2] == 'K')
            {
                attack++;
            }

            if (IsInMatrix(row + 2, col - 1, matrix.GetLength(0)) && matrix[row + 2, col - 1] == 'K')
            {
                attack++;
            }

            if (IsInMatrix(row - 2, col - 1, matrix.GetLength(0)) && matrix[row - 2, col - 1] == 'K')
            {
                attack++;
            }

            if (IsInMatrix(row + 2, col + 1, matrix.GetLength(0)) && matrix[row + 2, col + 1] == 'K')
            {
                attack++;
            }

            if (IsInMatrix(row - 2, col + 1, matrix.GetLength(0)) && matrix[row - 2, col + 1] == 'K')
            {
                attack++;
            }

            return attack;
        }

        private static bool IsInMatrix(int row, int col, int lenght)
        {
            return row >= 0 && row < lenght && col >= 0 && col < lenght;
        }
    }
}
