using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Array
{
    class MinValue
    {
        static void Main(string[] args)
        {
            int min = minV(6, 5, 3, 0, -4, 8);

            Console.WriteLine("The minimum is :{0} ", min);
        }

        public static int minV(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach(int number in numbers)
            {
                if (number < min)
                    min = number;
            }
            return min;
        }
    }
}
