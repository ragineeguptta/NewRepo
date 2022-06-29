using System;

namespace Excersizeapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //define few variables
           int age = 24;
           string name = "Raginee";

           // 1. string concatenation 
           Console.WriteLine("String Concatenation");
           Console.WriteLine("Hello, my name is " + name + ", I am " + age + " years old");

            // 2. String formatting.
            //string formatting uses index
            Console.WriteLine("String Formating");
            Console.WriteLine("Hello, my name is {0}, I am {1} years old", name, age);

            // 3. String interpolation.
            //string interpolation uses $ at the start which will allow us to write our
            //variables like this {variableName}
            Console.WriteLine("String interpolation.");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");
          
            //4. Verbatim strings.
            //verbatim start with @ and tells the compiler to take the string
            //literally  and ignore any spaces and escape characters like \n
            Console.WriteLine("Varbatim String");
            Console.WriteLine(@"my name is
raginee            gupta

hello
");
            Console.ReadLine();
        }
    }
}
