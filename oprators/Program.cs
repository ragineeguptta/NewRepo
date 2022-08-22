using System;

namespace oprators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num3;
            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}",num3);

            bool isSunny = true;
            Console.WriteLine("is it Sunny? {0}", !isSunny);

            // increment operators
            num3 = 0;
            num3++;
            Console.WriteLine("num3 is {0}", num3);
            Console.WriteLine("num3 is {0}", num3++);
            // pre increament oprATOR
            Console.WriteLine("num3 is {0}", ++num3);

            // DEcrement operators
            num3 = 0;
            num3--;
            Console.WriteLine("num3 is {0}", num3);
            Console.WriteLine("num3 is {0}", num3--);
            // pre DEcrement oprATOR
            Console.WriteLine("num3 is {0}", --num3);


            Console.ReadKey();
        }
    }
}
