using System;

namespace Excersizeapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //integer
            // declaring a variable
            int num1;
            // assigning a value to a variable
            num1 = 13;
            //declaring and initializing a variable in one go
            int num2 = 23;
            int sum = num1+ num2;

            //using concatination
            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            //Double
            double d1 = 3.5342;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            //Float
            float f1 = 3.5342f;
            float f2 = 5.1f;
            float fDiv = f1/ f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            //Long
            long l1 = 532626547869767361;


            //diff variable inone 
            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num2 is " + dIDiv);

            Console.Read();
        }
    }
}
