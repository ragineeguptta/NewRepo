using System;
using System.Collections.Generic;
using System.Text;

namespace StructsC
{
    class EnumsC
    {
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su};
        enum Month { January = 1, February, March, April, May, June, July = 12, August, September, October, November, December };
        static void Main1(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);
            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);
            Console.WriteLine((int)Month.February);
            Console.WriteLine((int)Month.August);
            Console.ReadKey();
        }
    }
}
