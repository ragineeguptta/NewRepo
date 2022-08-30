using System;

namespace MakingDecision
{
    class Program
    {
        static int highscore = 300;
        static string highplayerName = "Raginee";
        static void Main2(string[] args)
        {
            CheckHighScore(250, "aa");
            CheckHighScore(350, "bb");
            CheckHighScore(330, "cc");

            Console.Read();

            ////Switch Statement

            //int age = 79;

            //switch (age)
            //{
            //    case 15:
            //        Console.WriteLine("Too young");
            //        break;
            //    case 25:
            //        Console.WriteLine("Good to go");
            //        break;
            //    default:
            //        Console.WriteLine("Too old");
            //        break;

            //}
            //Console.Read();
        }
        public static void CheckHighScore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highplayerName = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {

                Console.WriteLine("The old highscore could not be broken. It is still " + highscore + " and held by " + highplayerName);
            }
        }
    }
}
