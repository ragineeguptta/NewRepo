using System;
using System.Collections.Generic;
using System.Text;

namespace MakingDecision
{
    class StateOfMattter
    {
        // Inhenchment of if statement - ternary- oprator
        static void Main3(string[] args)
        {
            int temp = -5;
            string stateOfMatter;

            if (temp < 0)
                stateOfMatter = "Solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temp += 30;

            //in short
            stateOfMatter = temp < 0 ? "solid" : "Liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            //challenges
            temp += 100;
            stateOfMatter = temp > 100 ? "gas" : temp < 0 ? "Solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.ReadKey();
        }
    }
}
