using System;

namespace HelloWorldd
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Raginee";
            string friend2 = "Gunjan";
            string friend3 = "Shashikala";

            //GreetFriend(friend1);
            //GreetFriend(friend2);
            //GreetFriend(friend3);
            GreetFriend(friend1, friend2, friend3);
            Console.Read();
        }

        
        public static void GreetFriend(string friendName, string friend2, string friend3)
        {
            //Console.WriteLine("Hi " + friendName + ", my friend!");
            Console.WriteLine("Hi " + friendName + ", my friend!");
            Console.WriteLine("Hi " + friend2 + ", my friend!");
            Console.WriteLine("Hi " + friend3 + ", my friend!");
        }
    }
}
