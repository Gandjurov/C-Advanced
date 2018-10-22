using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class ProductShop
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            string line;

            while ((line = Console.ReadLine()) != "Revision")
            {
                string[] productInfo = line.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shop = productInfo[0];
                string product = productInfo[1];
                double price = double.Parse(productInfo[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                shops[shop].Add(product, price);
            }

            var orderedShops = shops.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderedShops)
            {
                var shop = kvp.Key;
                var products = kvp.Value;

                Console.WriteLine($"{shop}->");

                foreach (var item in products)
                {
                    var product = item.Key;
                    var price = item.Value;
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}
