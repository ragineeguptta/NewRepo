using System;

namespace MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch Statement

            int age = 79;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young");
                    break;
                case 25:
                    Console.WriteLine("Good to go");
                    break;
                default:
                    Console.WriteLine("Too old");
                    break;

            }
            Console.Read();
        }
    }
}
