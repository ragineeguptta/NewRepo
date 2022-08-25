using System;

namespace oprators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
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
            num3--;
            Console.WriteLine("num3 is {0}", num3);
            Console.WriteLine("num3 is {0}", num3--);
            // pre DEcrement oprATOR
            Console.WriteLine("num3 is {0}", --num3);


            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            //relational and type oprators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("result of num1 >num2 is {0}", isLower);

            //equality oprator

            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            // conditional operators
            bool isLowerAndSunny;
            // conditional AND operators
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result od isLower && isSunny is {0} ", isLowerAndSunny);


            // conditional OR operators
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result od isLower || isSunny is {0} ", isLowerAndSunny);

            Console.ReadKey();
        }
    }
}
