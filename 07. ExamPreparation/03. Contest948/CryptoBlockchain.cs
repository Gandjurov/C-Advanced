using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Contest948
{
    class CryptoBlockchain
    {
        static void Main(string[] args)
        {
            //pattern:
            //{[^\]\[{]+}|\[[^{}\[]+\]

            int n = int.Parse(Console.ReadLine());

            string sequence = "";
            string output = "";

            for (int i = 0; i < n; i++)
            {
                sequence += Console.ReadLine();
            }

            string pattern = @"{[^\]\[{]+}|\[[^{}\[]+\]";
            MatchCollection matches = Regex.Matches(sequence, pattern);

            List<string> validMatches = new List<string>();

            foreach (var match in matches)
            {
                validMatches.Add(match.ToString());
            }

            for (int i = 0; i < validMatches.Count; i++)
            {
                string nums = "";

                for (int j = 0; j < validMatches[i].Length; j++)
                {
                    if (char.IsDigit(validMatches[i][j]))
                    {
                        nums += validMatches[i][j];
                    }
                }

                if (nums.Length % 3 != 0)
                {
                    continue;
                }

                string numPattern = @"[0-9]{3}";
                MatchCollection numMatches = Regex.Matches(nums, numPattern);

                foreach (var match in numMatches)
                {
                    int num = int.Parse(match.ToString());
                    num -= validMatches[i].Length;
                    char ch = (char)num;
                    output += ch;
                }
            }

            Console.WriteLine(output);
        }
    }
}
