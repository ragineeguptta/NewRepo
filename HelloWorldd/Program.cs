using System;

namespace HelloWorldd
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteSomething();
            //WriteSomethingSpecific("I am an argument and called from a method");
            //Console.Read();
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine(Add(10, 20));
            Console.WriteLine(Multiply(25, 13));
            Console.Read();
        }

        ////accessmodifier, (static), retun type, method name (parameter1)
        //public static void WriteSomething()
        //{
        //    Console.WriteLine("I am called by method");
        //}

        //public static void WriteSomethingSpecific(string myText)
        //{
        //    Console.WriteLine(myText);
        //}

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
