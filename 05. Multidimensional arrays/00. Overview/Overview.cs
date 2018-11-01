using System;

namespace Overview
{
    class Overview
    {
        static void Main(string[] args)
        {
            // 1. Matrices and Multidimensional Arrays
            //  - Creating 
            //  - Accessing elements
            //  - Reading and Printing

            //Creating:
            //  - Use the NEW keyword
            //  - Must specify the size of each dimension
            //  - This syntax is specific only to C#

            int[,] intMatrix = new int[3, 4];
            float[,] floatMatrix = new float[8, 2];
            string[,,] stringCube = new string[5, 5, 5];


            //Matrix:
            int[,] matrix =
            {
                { 1, 6, 4, 8, 3},
                { 2, 3, 5, 7, 23},
                { 2, 3, 5, 7, 23},
                { 2, 3, 5, 7, 23}
            };

            //foreach (var item in matrix)
            //{
            //    Console.WriteLine(item);
            //}

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col < (matrix.GetLength(1) - 1))
                    {
                        Console.Write($"{matrix[row, col]},");
                    }
                    else
                    {
                        Console.Write($"{matrix[row, col]}");
                    }
                    
                }
                Console.WriteLine();
            }


            //2. Jagged Arrays(arrays of arrays)
            //  - Creating 
            //  - Accessing elements
            //  - Reading and Printing

            //Each of the arrays has different length
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[3];
            //jagged[1] = new int[2];

            //Accessing element
            //int element = jagged[0][0];

            //Filling a Jagged Array
            int[][] jagged = new int[5][];

            for (int row = 0; row < jagged.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split(' ');
                jagged[row] = new int[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(inputNumbers[col]);
                }
            }
        }
    }
}
