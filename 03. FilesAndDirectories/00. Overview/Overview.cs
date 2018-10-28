using System;
using System.IO;

namespace _00._Overview
{
    class Overview
    {
        static void Main(string[] args)
        {
            // Files:

            //  ReadAllText() - reads everything at once and returns a string  / returns string
            //  ReadAllLines() - reads line by line and returns a collection  / returns array

            //  WriteAllText() - takes a string and writes it to a file
            //  WriteAllLine() - takes a collection and writes every element on a new line

            //File.Create("Numbers.txt");
            //File.Copy("Numbers.txt", "../another.txt");
            //File.Exists("someFile"); - returns true or false

            //string numbers = File.ReadAllText("Numbers.txt");
            //Console.WriteLine(numbers);

            //File.WriteAllText("somefile.txt", "some text here");
            //File.WriteAllLines("lines.txt", new string[]
            //{
            //    "first row",
            //    "second row",
            //    "third row",
            //});

            //StreamReader()

            //using (var reader = new StreamReader("Test.txt"))
            //{
            //    string currentLine = reader.ReadLine();
            //    Console.WriteLine(currentLine);
            //}


            //StreamWriter():

            //using (var writer = new StreamWriter("bigFile.txt"))
            //{
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        writer.WriteLine(Guid.NewGuid().ToString());
            //    }
            //}

                // Directories:

            //  CreateDirectory() - creates the dictionary and all subdirectories at the specified path, unless they already exist
            //  Delete() - deletes an empty directory
            //  Move() - moves a file or directory to a new location
            //  GetFiles() - returns the names of files (including their parths) in the specified directory
            //  GetDirectories() - returns the names of subdirectories (including their paths) in the specified directory

            //Directory.CreateDirectory("Test");

            //if (!Directory.Exists("Test"))
            //{
            //    Directory.CreateDirectory("Test");
            //}

            //Directory.Delete("Test", true);

            //string[] dirs = Directory.GetDirectories("Test");

            //string[] files = Directory.GetFiles(dirs[0]);

            //Console.WriteLine(File.ReadAllText(files[0]));

            

            //Recursion:

            TraverseDirectory("Test");


        }

        public static void TraverseDirectory(string directory)
        {
            if (directory == null || !Directory.Exists(directory))
            {
                return;
            }

            Console.WriteLine($"--{directory}--");

            string[] allFiles = Directory.GetFiles(directory);

            foreach (var file in allFiles)
            {
                Console.WriteLine(file);
            }

            string[] allDirs = Directory.GetDirectories(directory);

            foreach (var dir in allDirs)
            {
                TraverseDirectory(dir);
            }
        }
    }
}
