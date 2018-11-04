using System;
using System.Linq;
using System.Collections.Generic;

namespace CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(w => Char.IsUpper(w[0]))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
