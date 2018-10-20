using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbersWithStack
{
    class ReverseNumbersWithStack
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            Stack<long> stack = new Stack<long>();

            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            Console.Write(string.Join(" ", stack));
            Console.WriteLine();
        }
    }
}
