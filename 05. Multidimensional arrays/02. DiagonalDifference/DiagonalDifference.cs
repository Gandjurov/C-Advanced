using System;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                primarySum += matrix[row][row];
                secondarySum += matrix[row][matrix.Length - 1 - row];
            }

            int result = Math.Abs(primarySum - secondarySum);
            Console.WriteLine(result);
        }
    }
}
