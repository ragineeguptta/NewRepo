using System;

namespace MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string regiName = "";
            string regiPass = "";
            string logName = "";
            string logPass = "";

            Console.WriteLine("Please enter your Register Name");
            regiName = Console.ReadLine();
            Console.WriteLine("Please enter your Register Password");
            regiPass = Console.ReadLine();

            Console.WriteLine("Please enter your Login Name");
            logName = Console.ReadLine();
            Console.WriteLine("Please enter your Login Password");
            logPass = Console.ReadLine();

            if (regiName == logName)
            {
                Console.WriteLine("Congratulation you loged in.");
            }
            else
            {
                Console.WriteLine("Incorrect username and password.");
            }

            //bool isAdmin = false;
            //bool isRegistered = true;
            //string userName = "";
            //Console.WriteLine("Please enter your userName");

            //userName = Console.ReadLine();
            //if (isRegistered && userName != "" && userName.Equals("admin"))
            //{
            //    Console.WriteLine("Hey there, " + userName);
            //}

            //if(isAdmin || isRegistered)
            //{
            //    Console.WriteLine("you are logged in");
            //}
            Console.Read();

            //Console.WriteLine("What's the temperature like?");
            //string temperature = Console.ReadLine();
            //int numTemp;
            //int number;
            //if(int.TryParse(temperature, out number))
            //{
            //    numTemp = number;
            //}
            //else
            //{
            //    numTemp = 0;
            //    Console.WriteLine("Value entered, was no number. 0 set as temperature.");
            //}

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

        }
    }
}
