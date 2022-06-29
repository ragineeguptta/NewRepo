using System;

namespace Excersizeapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            string name = "Raginee";
            string message = "My name is  " + name;
            string capsMessage = message.ToUpper();
            Console.WriteLine(capsMessage);

            Console.Read();
        }
    }
}
