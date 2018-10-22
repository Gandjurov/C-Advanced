using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(currentNumber, 0);
                }

                numbers[currentNumber] += 1;
            }

            Console.WriteLine(numbers.Where(x => x.Value % 2 == 0).FirstOrDefault().Key);
        }
    }
}
