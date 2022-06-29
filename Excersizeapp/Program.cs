using System;

namespace Excersizeapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int result = num1 + num2;

            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            int i = Int32.Parse(stringForInt);
            float f = float.Parse(stringForFloat);

            System.Console.WriteLine("Int = {0}, Float = {1}", i, f);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
