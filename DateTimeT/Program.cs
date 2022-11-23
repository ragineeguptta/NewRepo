using System;

namespace DateTimeT
{
    class Program
    {
        static void Main1(string[] args)
        {
            DateTime dateTime = new DateTime(1998, 2, 19);
            Console.WriteLine("My birthday is " + dateTime);


            //today
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrorw();
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);
            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
            Console.WriteLine(GetFirstDayOfYear(1999));


            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}", days);
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Days in Feb 2001: {0}", days);
            days = DateTime.DaysInMonth(2002, 2);
            Console.WriteLine("Days in Feb 2002: {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}", now.Minute);

            // display the time in this structure x o'clock and y minutes AND z seconds
            
            Console.WriteLine("{0} o'clock and {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);
            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.WriteLine("Write ayour birthday date in this format: yyyy-mm-dd");


        }

        static DateTime GetTomorrorw()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
