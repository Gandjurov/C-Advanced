using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int operationCount = int.Parse(Console.ReadLine());
            string text = String.Empty;
            var textVersions = new Stack<string>();

            for (int i = 0; i < operationCount; i++)
            {
                var input = Console.ReadLine()
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int operation = int.Parse(input[0]);

                switch (operation)
                {
                    case 1:
                        textVersions.Push(text);
                        text += input[1];
                        break;

                    case 2:
                        textVersions.Push(text);
                        int symbolsToRemove = int.Parse(input[1]);
                        text = text.Substring(0, text.Length - symbolsToRemove);
                        break;

                    case 3:
                        int index = int.Parse(input[1]);
                        Console.WriteLine(text[index - 1]);
                        break;

                    case 4:
                        text = textVersions.Pop();
                        break;
                        
                }


            }

        }
    }
}
