using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> sortedSet = new SortedSet<string>();
            List<string> helperList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var inputElement = Console.ReadLine().Split(' ').ToList();

                foreach (var item in inputElement)
                {
                    helperList.Add(item);
                }

                foreach (var item in helperList)
                {
                    sortedSet.Add(item);
                }
            }

            foreach (var item in sortedSet)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
