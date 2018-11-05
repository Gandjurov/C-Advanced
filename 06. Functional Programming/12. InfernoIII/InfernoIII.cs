using System;
using System.Collections.Generic;
using System.Linq;

namespace InfernoIII
{
    class InfernoIII
    {
        static void Main()
        {
            Action<List<int>> print = p => Console.WriteLine(string.Join(" ", p));

            var filters = new Dictionary<string, Dictionary<int, Func<int, int, bool>>>();

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Forge")
            {
                //input like this:
                //Exclude;Sum Left;1
                string[] commandArgs = input.Split(';');

                string command = commandArgs[0];
                string funcName = commandArgs[1];
                int value = int.Parse(commandArgs[2]);

                Func<int, int, bool> sumFunc = GetFunction(numbers, funcName);

                if (command == "Exclude")
                {
                    if (!filters.ContainsKey(funcName))
                    {
                        filters.Add(funcName, new Dictionary<int, Func<int, int, bool>>());
                    }

                    if (!filters[funcName].ContainsKey(value))
                    {
                        filters[funcName].Add(value, sumFunc);
                    }
                }
                else
                {
                    if (filters.ContainsKey(funcName))
                    {
                        filters[funcName].Remove(value);
                    }
                }

                input = Console.ReadLine();
            }

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                bool isValid = true;
                
                foreach (var filter in filters)
                {
                    foreach (var kvp in filter.Value)
                    {
                        if (kvp.Value(i, kvp.Key))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                if (isValid)
                {
                    result.Add(numbers[i]);
                }
            }

            print(result);
        }

        private static Func<int, int, bool> GetFunction(List<int> numbers, string funcName)
        {
            if (funcName == "Sum Left")
            {
                return (a, b) => a == 0 ? numbers[0] == b : numbers[a] + numbers[a - 1] == b;
            }
            else if (funcName == "Sum Right")
            {
                return (a, b) => a == numbers.Count - 1 && numbers.Count == 1 ? numbers[0] == b : numbers[a] + numbers[a + 1] == b;
            }
            else if (funcName == "Sum Left Right")
            {
                return (a, b) => numbers.Count == 1 ? numbers[a] == b :
                                 a == numbers.Count - 1 ? numbers[a - 1] + numbers[a] == b :
                                 a == 0 ? numbers[a] + numbers[a + 1] == b :
                                 numbers[a - 1] + numbers[a] + numbers[a + 1] == b;
            }

            return null;
        }
    }
}
