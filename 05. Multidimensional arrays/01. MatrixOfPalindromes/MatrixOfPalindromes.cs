using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[input[0], input[1]];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write($"{alphabet[row]}{alphabet[row]}{alphabet[row]} ");
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{alphabet[row]}{alphabet[col + row]}{alphabet[row]} ");
                }
                Console.WriteLine();
            }

            //char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            //int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //int rows = input[0];
            //int cols = input[1];

            //string[][] matrixOfPolindromes = new string[rows][];

            //for (int row = 0; row < matrixOfPolindromes.Length; row++)
            //{
            //    matrixOfPolindromes[row] = new string[cols];

            //    for (int col = 0; col < matrixOfPolindromes[row].Length; col++)
            //    {
            //        char firstLetter = alphabet[row];
            //        char middleLetter = alphabet[rows + cols];

            //        matrixOfPolindromes[row][col] = $"{firstLetter}{middleLetter}{firstLetter}";

            //        Console.WriteLine($"{matrixOfPolindromes[row][col]} ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
