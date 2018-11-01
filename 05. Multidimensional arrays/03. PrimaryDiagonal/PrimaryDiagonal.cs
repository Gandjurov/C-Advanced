using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            int sumDiagonal = 0;

            for (int row = 0; row < size; row++)
            {
                int[] inputCurrRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                matrix[row, row] = inputCurrRow[row];
                sumDiagonal += matrix[row, row];
                
            }

            Console.WriteLine(sumDiagonal);
        }
    }
}
