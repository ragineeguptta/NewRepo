using System;
using System.Collections.Generic;

namespace Delegates_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of names
            List<string> names = new List<string>() { "aiaa", "bbib", "ccc", "ddidd" };


            Console.WriteLine("-------before------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //caling removeAll and passing a method filter we created.
            names.RemoveAll(Filter);

            Console.WriteLine("---------after---------");
            //print the names after the remove all method
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        //a method called a filter that takes a string
        static bool Filter(string s)
        {
            //return whether the string s contains the letter 'i'
            //the contains method will return a bool which we will return as well
            return s.Contains("i");
        }
    }
}
