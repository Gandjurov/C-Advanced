using System;
using System.Linq;

namespace SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] characters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = characters[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    bool areEqual = matrix[row, col] == matrix[row, col + 1] &&
                                    matrix[row, col] == matrix[row + 1, col + 1] &&
                                    matrix[row, col] == matrix[row + 1, col];

                    if (areEqual)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
