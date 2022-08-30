using System;
using System.Collections.Generic;
using System.Text;

namespace MakingDecision
{
    class TernaryOperator_Challenge
    {

        static int temperature;
        static void Main(string[] args)
        {
            int inputTemp = 0;
            string tempMessage = string.Empty;
            string inputValue = string.Empty;

            //takes input from console
            Console.Write("Enter the current temprerature : ");
            inputValue = Console.ReadLine();

            //validate the input as valid input integer value
            bool validInteger = int.TryParse(inputValue, out inputTemp);


            if (validInteger)
            {
                tempMessage = inputTemp <= 15 ? "It is too cold here" : (inputTemp >= 16 && inputTemp <= 28) ? "it is ok" : inputTemp > 28 ? "it is hot here" : "";
                Console.WriteLine(tempMessage);
            }
            else

            {
                Console.WriteLine("Not a valid Temprature");
            }
            Console.ReadKey();
        }
    }
}
