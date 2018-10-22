using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentItem = clothes[j];

                    if (!wardrobe[color].ContainsKey(currentItem))
                    {
                        wardrobe[color].Add(currentItem, 0);
                    }

                    wardrobe[color][currentItem] += 1;
                }
            }

            string[] targetItem = Console.ReadLine().Split();

            string targetColor = targetItem[0];
            string itemName = targetItem[1];

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes: ");

                foreach (var item in kvp.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");

                    if (kvp.Key == targetColor && item.Key == itemName)
                    {
                        Console.Write($" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
