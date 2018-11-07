using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Contest995
{
    class MovieTime
    {
        static void Main(string[] args)
        {
            var movieList = new Dictionary<string, Dictionary<string, TimeSpan>>();

            string favGenre = Console.ReadLine();
            string favDuration = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "POPCORN!")
            {
                //Pick This|Drama|00:12:25
                string[] inputArgs = input.Split('|');

                string movieName = inputArgs[0];
                string genre = inputArgs[1];
                string duration = inputArgs[2];

                TimeSpan time = TimeSpan.Parse(duration, CultureInfo.InvariantCulture);

                if (!movieList.ContainsKey(genre))
                {
                    movieList.Add(genre, new Dictionary<string, TimeSpan>());
                }
                if (!movieList[genre].ContainsKey(movieName))
                {
                    movieList[genre].Add(movieName, time);
                }
                

                input = Console.ReadLine();
            }

            if (favDuration == "Short")
            {
                movieList[favGenre] = movieList[favGenre]
                    .OrderBy(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, y => y.Value);
            }
            else
            {
                movieList[favGenre] = movieList[favGenre]
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, y => y.Value);
            }

            foreach (var movieKVP in movieList[favGenre])
            {
                Console.WriteLine(movieKVP.Key);
                string wifeCommands = Console.ReadLine();

                if (wifeCommands == "Yes")
                {
                    var totalSeconds = movieList.Values.Sum(x => x.Sum(s => s.Value.TotalSeconds));

                    int hours = (int)totalSeconds / 60 / 60;
                    int minutes = (int)totalSeconds / 60 % 60;
                    int seconds = (int)totalSeconds % 60;
                    

                    Console.WriteLine($"We're watching {movieKVP.Key} - {movieKVP.Value}");
                    Console.WriteLine($"Total Playlist Duration: {hours:D2}:{minutes:D2}:{seconds:D2}");
                    return;
                }
            }
        }
    }
}
