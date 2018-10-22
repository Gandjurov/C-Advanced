using System;
using System.Collections.Generic;

namespace HashSets
{
    class HashSets
    {
        static void Main(string[] args)
        {
            // Sets in C#
            //  A set keep unique elements
            //      Provides methods for adding/removing/searching elements
            //      Offers very fast performance

            //HashSet<T>
            //      The elements are randomly ordered
            //Add()
            //Remove()
            //Contains()


            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(1);
            set.Add(2);
            set.Add(5);
            set.Add(1);
            set.Add(1);
            set.Add(10);
            set.Add(1);

            Console.WriteLine(set.Count);

            Console.WriteLine(set.Contains(1));

            set.Remove(1);

            Console.WriteLine(set.Contains(1));

            Console.WriteLine(set.Count);


            foreach (var item in set)
            {
                Console.WriteLine(item);
            }


            //SortedSet<T>
            //      The elements are ordered incrementally
            //Max()
            //Min()
            SortedSet<int> sortedSet = new SortedSet<int>();

            sortedSet.Add(1);
            sortedSet.Add(1);
            sortedSet.Add(100);
            sortedSet.Add(2);
            sortedSet.Add(1);

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(sortedSet.Max);
        }
    }
}
