using System;

namespace MakingDecision
{
    class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();

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
        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration Completed");
            Console.WriteLine("--------------------------------------------------");

        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login Succesfull");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong passward. Restart program");
                }

            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart program");
            }
        }
    }
}
