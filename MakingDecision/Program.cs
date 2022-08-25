using System;

namespace MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            //int temperature = 10;

            //if (temperature < 10)
            //{
            //    Console.WriteLine("Take the coat");
            //}

            //if (temperature == 10)
            //{
            //    Console.WriteLine("The temp is 10 degree");
            //}
            //if (temperature > 10)
            //{
            //    Console.WriteLine("Cozy and Warm");
            //}

            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if(numTemp < 20)
            {
                Console.WriteLine("Take the Coat");
            }

            else if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }

            else
            {
                Console.WriteLine("Short are enough today");
            }

            Console.Read();
        }
    }
}
