using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var inputName = Console.ReadLine();

                set.Add(inputName);
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
