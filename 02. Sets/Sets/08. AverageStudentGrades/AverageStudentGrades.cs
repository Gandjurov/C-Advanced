using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());

            var marks = new Dictionary<string, List<double>>();

            for (int i = 0; i < nums; i++)
            {
                string[] inputStudents = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputStudents[0];
                double mark = double.Parse(inputStudents[1]);
                
                if (!marks.ContainsKey(name))
                {
                    marks[name] = new List<double>();
                    marks[name].Add(mark);
                }
                else
                {
                    marks[name].Add(mark);
                }
            }

            foreach (var pair in marks)
            {
                var name = pair.Key;
                var studentMarks = pair.Value;
                var average = studentMarks.Average();

                Console.Write($"{name} -> ");

                foreach (var mark in studentMarks)
                {
                    Console.Write($"{mark:F2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}
