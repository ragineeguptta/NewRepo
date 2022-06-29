using System;

namespace Excersizeapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int num = 123456633;
            long bignum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double d1 = 13.37;
            int myInt;
            //explicit conversion
            myInt = (int)d1;


            //typeConversion
            string myString = myNewDouble.ToString();

            Console.WriteLine(myInt);
            Console.Read();
        }
    }
}
