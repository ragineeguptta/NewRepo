using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment3Parsing_game_part_2_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"D:\AllProjectByRaginee\CSharp\Assignment3Parsing-game-part 2-Regular-Expressions\input2.txt");
            string pattern = @"\d{3}|\d{2}";
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);



            using (StreamWriter file = new StreamWriter(@"D:\AllProjectByRaginee\CSharp\Assignment3Parsing-game-part 2-Regular-Expressions\output2.txt"))
            {
                foreach (Match match in matchCollection)
                {
                    int numbers = int.Parse(match.Value);
                    file.Write((char)numbers);
                }

            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
        
    }
}
