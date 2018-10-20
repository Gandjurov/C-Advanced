using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            int N = numbers[0];
            int S = numbers[1];
            int X = numbers[2];

            var inputSecondLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(inputSecondLine[i]);
            }

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count != 0)
            {
                if (queue.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
