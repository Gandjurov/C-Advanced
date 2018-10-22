using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();

            var entry = Console.ReadLine();

            while (entry?.ToLower() != "party")
            {
                if (char.IsDigit(entry[0]))
                {
                    vips.Add(entry);
                }
                else
                {
                    guests.Add(entry);
                }
                entry = Console.ReadLine();
            }

            entry = Console.ReadLine();

            while (entry?.ToLower() != "end")
            {
                if (char.IsDigit(entry[0]))
                {
                    vips.Remove(entry);
                }
                else
                {
                    guests.Remove(entry);
                }
                entry = Console.ReadLine();
            }

            Console.WriteLine(guests.Count + vips.Count);

            foreach (var vip in vips)
            {
                Console.WriteLine(vip);    
            }

            foreach (var guest in guests)
            {
               Console.WriteLine(guest);
            }
        }
    }
}
