using System;
using System.Collections.Generic;
using System.Linq;

namespace TheVLogger
{
    class TheVLogger
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> vLoggers = 
                new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            //vLoggers["pesho"]["following"].Add("targetUser");
            //vLoggers["pesho"]["followers"].Add("targetUser");

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] elements = input.Split();

                string user = elements[0];
                string command = elements[1];
                string targetUser = elements[2];

                if (command == "joined")
                {
                    if (!vLoggers.ContainsKey(user))
                    {
                        vLoggers.Add(user, new Dictionary<string, SortedSet<string>>());
                        vLoggers[user].Add("following", new SortedSet<string>());
                        vLoggers[user].Add("followers", new SortedSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    bool isSamePerson = user == targetUser;

                    if (vLoggers.ContainsKey(user) && vLoggers.ContainsKey(targetUser) && !isSamePerson)
                    {
                        vLoggers[user]["following"].Add(targetUser);
                        vLoggers[targetUser]["followers"].Add(user);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vLoggers.Count} vloggers in its logs.");

            var sortedVLoggers = vLoggers
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count);

            int counter = 1;

            foreach (var item in sortedVLoggers)
            {
                Console.WriteLine($"{counter}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                if (counter == 1)
                {
                    foreach (var followerName in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {followerName}");
                    }
                }
                counter++;
            }
        }
    }
}
