using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxNumber = int.MinValue;

            for (int i = 0; i < N; i++)
            {
                var commandParts = Console.ReadLine().Split(' ').ToArray();

                if (commandParts[0] == "1")
                {
                    int numToPush = int.Parse(commandParts[1]);
                    numbers.Push(numToPush);

                    if (maxNumbers.Count == 0 || numToPush >= maxNumbers.Peek())
                    {
                        maxNumbers.Push(numToPush);
                    }
                }

                if (commandParts[0] == "2")
                {
                    int elementAtTop = numbers.Pop();
                    int currentMaxNumber = maxNumbers.Peek();
                    if (elementAtTop == currentMaxNumber)
                    {
                        maxNumbers.Pop();
                    }
                }

                if (commandParts[0] == "3")
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
