using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> logsByUser = new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] logInfo = input.Split();

                string[] ipInfo = logInfo[0].Split('=');
                string ip = ipInfo[1];

                string[] userInfo = logInfo[2].Split('=');
                string user = userInfo[1];

                if (!logsByUser.ContainsKey(user))
                {
                    logsByUser.Add(user, new Dictionary<string, int>());
                    logsByUser[user].Add(ip, 0);
                }
                else if (!logsByUser[user].ContainsKey(ip))
                {
                    logsByUser[user].Add(ip, 0);
                }

                logsByUser[user][ip]++;

                input = Console.ReadLine();
            }

            foreach (var outerPair in logsByUser)
            {
                Console.WriteLine($"{outerPair.Key}");
                Console.WriteLine("{0}.", string.Join(", ", outerPair.Value.Select(x => $"{x.Key} => {x.Value}")));
            }
        }
    }
}
