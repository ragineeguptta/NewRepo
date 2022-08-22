using System;

namespace HelloWorldd
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }

        public static void Calculate()
        {
            Console.WriteLine("Please inter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please inter second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;


            Console.WriteLine(result);
        }
        
    }
}
