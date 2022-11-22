using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Parsing_game_part_1_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"D:\AllProjectByRaginee\CSharp\Parsing-game-part-1-Assignment\input.txt");
            using (StreamWriter file = new StreamWriter(@"D:\AllProjectByRaginee\CSharp\Parsing-game-part-1-Assignment\output.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("split"))
                    {
                        string[] saveLine = line.Split();
                        file.Write(saveLine[4] + " ");
                    }

                }
            }

        }
    }
}
