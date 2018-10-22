using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            var entry = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> carPlates = new HashSet<string>(); 

            while (entry[0]?.ToLower() != "end")
            {
                switch (entry[0]?.ToLower())
                {
                    case "in":
                        carPlates.Add(entry[1]);
                        break;
                    case "out":
                        carPlates.Remove(entry[1]);
                        break;

                    default:
                        break;
                }

                entry = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carPlates.Count > 0)
            {
                foreach (var plate in carPlates)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
