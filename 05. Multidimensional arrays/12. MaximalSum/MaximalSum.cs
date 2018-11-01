using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            int[,] matrixOfNumbers = new int[rows, cols];

            for (int row = 0; row < matrixOfNumbers.GetLength(0); row++)
            {
                int[] currentNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrixOfNumbers.GetLength(1); col++)
                {
                    matrixOfNumbers[row, col] = currentNumbers[col];
                }
            }

            int maxSum = int.MinValue;
            int targetRow = 0;
            int targetCol = 0;

            for (int row = 0; row < matrixOfNumbers.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrixOfNumbers.GetLength(1) - 2; col++)
                {
                    int sum = matrixOfNumbers[row, col] + matrixOfNumbers[row, col + 1] + matrixOfNumbers[row, col + 2] +
                        matrixOfNumbers[row + 1, col] + matrixOfNumbers[row + 1, col + 1] + matrixOfNumbers[row + 1, col + 2] +
                        matrixOfNumbers[row + 2, col] + matrixOfNumbers[row + 2, col + 1] + matrixOfNumbers[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        targetRow = row;
                        targetCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = targetRow; row <= targetRow + 2; row++)
            {
                for (int col = targetCol; col <= targetCol + 2; col++)
                {
                    Console.Write(matrixOfNumbers[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
