using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Contest995
{
    class TicketTrouble
    {
        static void Main(string[] args)
        {
            List<string> seats = new List<string>();

            string squarePattern = @"\[[^\]]*{([A-Z]{3} [A-Z]{2})}.*?{([A-Z]{1}[0-9]{1,2})}[^[]*\]";
            string curylePattern = @"{[^}]*\[([A-Z]{3} [A-Z]{2})\].*?\[([A-Z]{1}[0-9]{1,2})\][^{]*}";

            string destination = Console.ReadLine();
            string input = Console.ReadLine();

            MatchCollection squareCollection = Regex.Matches(input, squarePattern);
            MatchCollection curyleCollection = Regex.Matches(input, curylePattern);

            AddSeats(seats, destination, squareCollection);
            AddSeats(seats, destination, curyleCollection);

            if (seats.Count == 2)
            {
                Console.WriteLine($"You are traveling to {destination} on seats {seats[0]} and {seats[1]}.");
            }
            else
            {
                for (int i = 0; i < seats.Count; i++)
                {
                    for (int j = i + 1; j < seats.Count; j++)
                    {
                        string firstRow = seats[i].Substring(1);
                        string secondRow = seats[j].Substring(1);

                        if (firstRow == secondRow)
                        {
                            Console.WriteLine($"You are traveling to {destination} on seats {seats[i]} and {seats[j]}.");
                            return;
                        }
                    }
                }
            }
        }

        private static void AddSeats(List<string> seats, string destination, MatchCollection collection)
        {
            foreach (Match item in collection)
            {
                if (item.Groups[1].Value.Contains(destination))
                {
                    seats.Add(item.Groups[2].Value);
                }
                
            }
        }
    }
}
