using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveBunnies
{
    class RadioactiveBunnies
    {
        static int playerRow;
        static int playerCol;
        static char[][] jaggedArray;
        static bool isOutside;
        static bool isDead;

        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            jaggedArray = new char[rows][];

            GetJaggetArray(cols);

            string directions = Console.ReadLine();

            MovePlayers(directions);
        }

        private static void MovePlayers(string directions)
        {
            for (int i = 0; i < directions.Length; i++)
            {
                char currentStep = directions[i];

                if (currentStep == 'U')
                {
                    Move(-1, 0);
                }
                else if (currentStep == 'L')
                {
                    Move(0, -1);
                }
                else if (currentStep == 'R')
                {
                    Move(0, 1);
                }
                else if (currentStep == 'D')
                {
                    Move(1, 0);
                }

                Spread();

                if (isDead)
                {
                    PrintJaggedArray();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    break;
                }
                else if (isOutside)
                {
                    PrintJaggedArray();
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    break;
                }
            }
        }

        private static void Spread()
        {
            Queue<int[]> indexes = new Queue<int[]>();

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (jaggedArray[row][col] == 'B')
                    {
                        indexes.Enqueue(new int[] { row, col });
                    }
                }
            }

            while (indexes.Count > 0)
            {
                int[] currentIndex = indexes.Dequeue();

                int targetRow = currentIndex[0];
                int targetCol = currentIndex[1];

                // --------------------------------------------
                if (IsInside(targetRow - 1, targetCol))
                {
                    if (IsPlayer(targetRow - 1, targetCol))
                    {
                        isDead = true;
                    }
                    jaggedArray[targetRow - 1][targetCol] = 'B';
                }
                // --------------------------------------------
                if (IsInside(targetRow + 1, targetCol))
                {
                    if (IsPlayer(targetRow + 1, targetCol))
                    {
                        isDead = true;
                    }
                    jaggedArray[targetRow + 1][targetCol] = 'B';
                }
                // --------------------------------------------
                if (IsInside(targetRow, targetCol - 1))
                {
                    if (IsPlayer(targetRow, targetCol - 1))
                    {
                        isDead = true;
                    }
                    jaggedArray[targetRow][targetCol - 1] = 'B';
                }
                // --------------------------------------------
                if (IsInside(targetRow, targetCol + 1))
                {
                    if (IsPlayer(targetRow, targetCol + 1))
                    {
                        isDead = true;
                    }
                    jaggedArray[targetRow][targetCol + 1] = 'B';
                }
            }
        }

        private static bool IsPlayer(int row, int col)
        {
            return jaggedArray[row][col] == 'P';
        }

        private static void Move(int row, int col)
        {
            int targetRow = playerRow + row;
            int targetCol = playerCol + col;

            if (!IsInside(targetRow, targetCol))
            {
                jaggedArray[playerRow][playerCol] = '.';
                isOutside = true;
            }
            else if (IsBunny(targetRow, targetCol))
            {
                jaggedArray[playerRow][playerCol] = '.';
                playerRow += row;
                playerCol += col;
                isDead = true;
            }
            else
            {
                jaggedArray[playerRow][playerCol] = '.';

                playerRow += row;
                playerCol += col;

                jaggedArray[playerRow][playerCol] = 'P';
            }
        }

        private static bool IsBunny(int targetRow, int targetCol)
        {
            return jaggedArray[targetRow][targetCol] == 'B';
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < jaggedArray.Length &&
                col >= 0 && col < jaggedArray[row].Length;
        }

        private static void PrintJaggedArray()
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join("", jaggedArray[row]));
            }
        }

        private static void GetJaggetArray( int cols)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                string input = Console.ReadLine();

                jaggedArray[row] = new char[cols]; 

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = input[col];

                    if (jaggedArray[row][col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
