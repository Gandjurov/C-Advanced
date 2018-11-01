using System;
using System.Linq;

namespace GroupNumbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];

            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < 3; i++)
            {
                jaggedArray[i] = input
                .Where(x => Math.Abs(x) % 3 == i)
                .ToArray();
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
