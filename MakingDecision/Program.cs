using System;

namespace MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature.");
            }

            //string numberAsString = "128";
            //float parsedValue;

            //bool success = float.TryParse(numberAsString, out parsedValue);

            //if (success)
            //{
            //    Console.WriteLine("Parsing successful - number is " + parsedValue);
            //}

            //else
            //{
            //    Console.WriteLine("Parsing failed");
            //}


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



            //Console.WriteLine("What's the temperature like?");
            //string temperature = Console.ReadLine();
            //int numTemp = int.Parse(temperature);

            //if(numTemp < 20)
            //{
            //    Console.WriteLine("Take the Coat");
            //}

            //else if (numTemp == 20)
            //{
            //    Console.WriteLine("Pants and Pull Over should be fine");
            //}

            //else
            //{
            //    Console.WriteLine("Short are enough today");
            //}

            Console.Read();
        }
    }
}
