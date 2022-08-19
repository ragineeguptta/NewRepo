using System;

namespace Excersizeapp
{
    internal class Program
    {
        //constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const int days = 365;

        const string birthday = "15-07-1999";
        static void Main(string[] args)
        {
            Console.WriteLine("My Birthday is always going to be: {0}", birthday);
            Console.ReadKey();


            //Console.Write("Enter the string here: ");
            ////Read first input string.
            //string input = Console.ReadLine();

            //Console.Write("Enter a character to search: ");
            ////Read the character input to search.
            //char searchInput = Console.ReadLine()[0];
            ////Gets the index of the character from the string.
            //int searchIndex = input.IndexOf(searchInput);
            ////Prints the Index as a search result on console.
            //Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);


            //Console.Write("Enter first name: ");
            ////Read first name
            //string firstName = Console.ReadLine();
            //Console.Write("Enter last name: ");
            ////Read last name
            //string lastName = Console.ReadLine();

            ////Concatinate the firstName and lastName variable and assign that to fullName variable.
            //string fullName = string.Concat(firstName, " ", lastName);
            ////prints the full nameon the console.
            //Console.WriteLine("Your full name is {0}", fullName);

            //Console.ReadKey();
        }
    }
}
