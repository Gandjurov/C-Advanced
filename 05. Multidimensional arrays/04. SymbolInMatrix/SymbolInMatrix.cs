using System;
using System.Linq;

namespace SymbolInMatrix
{
    class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int rowPossition = 0;
            int colPossition = 0;
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] inputCurrRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = inputCurrRow[col];
                    if (!Char.IsLetter(inputCurrRow[col]))
                    {
                        rowPossition = row;
                        colPossition = col;
                        Console.WriteLine($"({rowPossition}, {colPossition})");
                        break;
                    }
                    else if (Char.IsLetter(inputCurrRow[col]))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{inputCurrRow[col]} does not occur in the matrix");
                    }
                }
                
            }
        }
    }
}
