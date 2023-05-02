using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int rows = 0; rows < n; rows++)
            {

                char[] arr = Console.ReadLine().ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[rows, col] = arr[col];
                }
            }

            char searchElement = char.Parse(Console.ReadLine());


            for (int rows = 0; rows < n; rows++)
            {

                for (int col = 0; col < n; col++)
                {
                    if (matrix[rows, col] == searchElement)
                    {
                        Console.WriteLine($"({rows}, {col})");
                        return;
                    }

                }
            }

            Console.WriteLine($"{searchElement} does not occur in the matrix");
        }
    }
}
