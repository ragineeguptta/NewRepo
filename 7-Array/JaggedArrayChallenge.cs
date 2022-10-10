using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Array
{
    class JaggedArrayChallenge
    {
        static void Main1(string[] args)
        {
            string[] joesFamily = new string[] { "Martha", "Robert" };

            string[][] friendAndFamily = new string[][]
            {
                new string[]{"Ashwini", "Vandna"},
                new string[]{"Raginee", "Vikas"},
                new string[]{"Gunjan", "Abhay"},
                joesFamily
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendAndFamily[0][0], friendAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendAndFamily[0][1], friendAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendAndFamily[0][1], friendAndFamily[2][1]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendAndFamily[3][1], friendAndFamily[2][1]);
            Console.ReadKey();
        }

    }
}
