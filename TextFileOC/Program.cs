using System;
using System.IO;

namespace TextFileOC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Example 1- reading text
            string text = System.IO.File.ReadAllText(@"D:\AllProjectByRaginee\CSharpTextFile.txt");
            Console.WriteLine("Text File contans following text: {0}", text);
            // Example 2- reading each line
            string[] lines = System.IO.File.ReadAllLines(@"D:\AllProjectByRaginee\CSharpTextFile.txt");
            Console.WriteLine("Contains of textfile.txt");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            

            // Example 1- writing text
            string[] lines = { "first line", "Second line", "third line" };
            File.WriteAllLines(@"D:\AllProjectByRaginee\CSharpTextFile2.txt", lines);
            Console.ReadKey();
            
            // Example 1- writing text and filename
            Console.WriteLine("Please enter the text for the file");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();

            File.WriteAllText(@"D:\AllProjectByRaginee\" + fileName + ".txt", input);

            */

            //Check for containt
            string[] lines = {"First 3235","Second 4567","Third 8976877" };
            using(StreamWriter file = new StreamWriter(@"D:\AllProjectByRaginee\myText.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                    
                }
            }

            using(StreamWriter file = new StreamWriter(@"D:\AllProjectByRaginee\myText.txt", true))
            {
                file.WriteLine("Additional line.");
            }
        }
    }
}
