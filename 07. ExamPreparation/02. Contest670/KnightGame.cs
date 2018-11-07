using System;

namespace Contest670
{
    class KnightGame
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] jaggedArr = new char[rows][];

            GetJaggedArr(jaggedArr);

            int targetRow = 0;
            int targetCol = 0;
            int removeKnights = 0;

            while (true)
            {
                int maxAttacked = 0;

                for (int row = 0; row < jaggedArr.Length; row++)
                {
                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        int attacked = 0;

                        if (jaggedArr[row][col] == 'K')
                        {
                            // up left
                            // up right
                            // down left
                            // down right
                            // left up
                            // left down
                            // right up
                            // right down

                            // up left
                            if (IsInside(jaggedArr, row - 2, col - 1) && jaggedArr[row - 2][col - 1] == 'K')
                            {
                                attacked++;
                            }

                            //up right:
                            if (IsInside(jaggedArr, row - 2, col + 1) && jaggedArr[row - 2][col + 1] == 'K')
                            {
                                attacked++;
                            }

                            //down left:
                            if (IsInside(jaggedArr, row + 2, col - 1) && jaggedArr[row + 2][col - 1] == 'K')
                            {
                                attacked++;
                            }

                            //down right:
                            if (IsInside(jaggedArr, row + 2, col + 1) && jaggedArr[row + 2][col + 1] == 'K')
                            {
                                attacked++;
                            }

                            //left up
                            if (IsInside(jaggedArr, row - 1, col - 2) && jaggedArr[row - 1][col - 2] == 'K')
                            {
                                attacked++;
                            }

                            //left down
                            if (IsInside(jaggedArr, row + 1, col - 2) && jaggedArr[row + 1][col - 2] == 'K')
                            {
                                attacked++;
                            }

                            //right up
                            if (IsInside(jaggedArr, row - 1, col + 2) && jaggedArr[row - 1][col + 2] == 'K')
                            {
                                attacked++;
                            }

                            //right down
                            if (IsInside(jaggedArr, row + 1, col + 2) && jaggedArr[row + 1][col + 2] == 'K')
                            {
                                attacked++;
                            }
                        }

                        if (attacked > maxAttacked)
                        {
                            maxAttacked = attacked;
                            targetRow = row;
                            targetCol = col;
                        }
                    }
                }

                if (maxAttacked > 0)
                {
                    jaggedArr[targetRow][targetCol] = '0';
                    removeKnights++;
                }
                else
                {
                    Console.WriteLine(removeKnights);
                    break;
                }
            }
        }

        private static bool IsInside(char[][] jaggedArr, int row, int col)
        {
            return row >= 0 && row < jaggedArr.Length && col >= 0 && col < jaggedArr.Length;
        }

        private static void GetJaggedArr(char[][] jaggedArr)
        {
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                jaggedArr[row] = Console.ReadLine().ToCharArray();
            }
        }
    }
}
