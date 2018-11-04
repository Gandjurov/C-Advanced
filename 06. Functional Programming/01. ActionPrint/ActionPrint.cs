using System;
using System.Linq;
using System.Collections.Generic;

namespace ActionPrint
{
    class ActionPrint
    {
        static void Main(string[] args)
        {
            Action<string[]> print = names => Console.WriteLine(string.Join(Environment.NewLine, names));

            string[] inputNames = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            print(inputNames);
        }
    }
    
}
