using System;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[rowCount][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new long[i + 1];
                jaggedArray[i][0] = 1;
                jaggedArray[i][i] = 1;
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                if (jaggedArray.Length > 2)
                {
                    for (int j = 1; j < jaggedArray[i].Length - 1; j++)
                    {
                        jaggedArray[i][j] = jaggedArray[i - 1][j] + jaggedArray[i - 1][j - 1];
                    }
                }
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
