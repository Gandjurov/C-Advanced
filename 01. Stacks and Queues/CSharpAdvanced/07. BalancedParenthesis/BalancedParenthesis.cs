using System;
using System.Collections.Generic;

namespace BalancedParenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            var parantheses = Console.ReadLine()
                .Trim()
                .ToCharArray();

            var stack = new Stack<char>();
            var paranthesesPair = new Dictionary<char, char>();
            paranthesesPair['{'] = '}';
            paranthesesPair['['] = ']';
            paranthesesPair['('] = ')';

            if (parantheses.Length % 2 != 0 || parantheses.Length == 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (var p in parantheses)
            {
                if (paranthesesPair.ContainsKey(p))
                {
                    stack.Push(p);
                }
                else
                {
                    var openParantheses = stack.Pop();
                    if (paranthesesPair[openParantheses] != p)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
