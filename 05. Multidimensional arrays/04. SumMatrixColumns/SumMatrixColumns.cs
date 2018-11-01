using System;
using System.Linq;

namespace SumMatrixColumns
{
    class SumMatrixColumns
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                    sum += matrix[row, col];
                }
            }

            int colSum = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    colSum += matrix[row, col];
                }
                Console.WriteLine($"{colSum}");
                colSum = 0;
            }
            
        }
    }
}
