using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimeT
{
    class Nullable
    {
        static void Main1(string[] args)
        {
            int? num1 = null;
            int? num2 = 4938;

            double? num3 = new Double?();
            double? num4 = 9.8347;

            bool? boolval = new bool?();

            Console.WriteLine("Our nullable numbers are: {0}, {1}, {2}, {3}", num1,num2,num3,num4);
            Console.WriteLine("The nullable boolean value is {0}", boolval);

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is Male");
            }
            else if(isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }

            double? num5 = 13.4;
            double? num6 = null;
            double num7;

            if(num5 == null)
            {
                num7 = 0.0;
            }
            else
            {
                num7 = (double)num5;
            }
            Console.WriteLine("Value of num7 is {0} ", num7);

            // Shoeter: THE NULL COALESCING OPERATOR ??
            num7 = num5 ?? 8.65;
            Console.WriteLine("Value of num7 is {0} ", num7);

            num7 = num6 ?? 8.65;
            Console.WriteLine("Value of num7 is {0} ", num7);
        }
    }
}
