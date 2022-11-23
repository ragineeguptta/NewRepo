using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimeT
{
    class MainArgsDemo
    {
        static void Main(string[] args)
        {
            //The args array cannot be null. so, it's safe to access the length property without null checking.
            //so we check the length of the array if it's zero it means no arguments were provided to the application
            if (args.Length == 0)
            {
                Console.WriteLine("Thes is a smart app that uses args ;),"
                    + " please provide arguments next time. Pass Help if you want to get moe details.");
                //pause the application so it doesn't quite after printing our error message
                Console.ReadKey();
                //quit the application entirly since we can't proceed further since, the arguments are empty
                return;
            }

            //check if the first command we got is help
            if(args[0] == "help")
            {
                //display manual
                Console.WriteLine("****************** Instructions:");
                Console.WriteLine("* use one of the following commands followed by 2 numbers");
                Console.WriteLine("* 'add' : to add 2 numbers");
                Console.WriteLine("* 'sub' : to subtract 2 numbers");
                Console.WriteLine("**************************");

                //pause
                Console.ReadKey();
                return;
            }
            //check the length of args
            if(args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                //pause
                Console.ReadKey();
                //quit the app
                return;
            }

            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invailid arguments, please use the help command for instructions");
                //pause
                Console.ReadKey();
                //quit the app
                return;
            }
            //a variable to store the resultts
            float result;

            switch (args[0])
            {
                //case 1 'add' add the two numbers and print the value
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"The sum of {num1} and {num2} is {result}", num1, num2, result);

                    break;
                case "sub":
                    result = num1 - num2;
                    Console.WriteLine($"The sub of {num1} and {num2} is {result}", num1, num2, result);

                    break;
                default:
                    Console.WriteLine("Invailid arguments, please use the help command for instructions");

                    break;
            }

            Console.ReadKey();
        }
    }
}
