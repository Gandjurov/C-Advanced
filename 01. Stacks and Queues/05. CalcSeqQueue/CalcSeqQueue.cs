using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcSeqQueue
{
    class CalcSeqQueue
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long> elementsInSeq = new Queue<long>();
            List<long> result = new List<long>();

            elementsInSeq.Enqueue(n);
            result.Add(n);
            while (result.Count < 50)
            {
                long currentElement = elementsInSeq.Dequeue();
                long firstNumber = currentElement + 1;
                long secondNumber = (currentElement * 2) + 1;
                long thirdNumber = currentElement + 2;

                elementsInSeq.Enqueue(firstNumber);
                elementsInSeq.Enqueue(secondNumber);
                elementsInSeq.Enqueue(thirdNumber);

                result.Add(firstNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
