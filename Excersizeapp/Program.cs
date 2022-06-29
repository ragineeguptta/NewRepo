using System;

namespace Excersizeapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Please enter your name and press enter");
            myName = Console.ReadLine();
            string myNameUppercase = String.Format("Upper case : {0}", myName.ToUpper());
            string myNameLowercase = String.Format("Lower case : {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed value : {0}", myName.Trim());
            string myNameSubString = String.Format("Suvstring value : {0}", myName.Substring(0, 5));
            Console.WriteLine(myNameUppercase);
            Console.WriteLine(myNameLowercase);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubString);

            Console.ReadKey();
        }
    }
}
