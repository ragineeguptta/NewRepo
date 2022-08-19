using System;

namespace HelloWorldd
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and called from a method");
            Console.Read();
        }

        //accessmodifier, (static), retun type, method name (parameter1)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called by method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}
