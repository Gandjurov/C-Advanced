using System;
using System.Linq;

namespace JaggedArrayModif
{
    class JaggedArrayModif
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rowCount][];

            for (int i = 0; i < rowCount; i++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArr[i] = currentRow;
            }

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            

            while (input[0]?.ToLower() != "end")
            {
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row < 0 ||
                    row > jaggedArr.Length - 1 ||
                    col < 0 ||
                    col > jaggedArr[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");

                    input = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    continue;
                }

                switch (input[0]?.ToLower())
                {
                    case "add":
                        jaggedArr[row][col] += value;
                        break;
                    case "subtract":
                        jaggedArr[row][col] -= value;
                        break;

                    default:
                        //Console.WriteLine("Invalid command!");
                        break;
                }

                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in jaggedArr)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
