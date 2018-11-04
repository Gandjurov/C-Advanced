using System;
using System.Linq;
using System.Collections.Generic;

namespace AddVAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n * 1.2)
                .ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
