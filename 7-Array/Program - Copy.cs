using System;

namespace _7_Array
{
    class Program_copy
    {
        static void Main1(string[] args)
        {
            //declare and initialize array grades
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 21;
            grades[2] = 22;
            grades[3] = 23;
            grades[4] = 24;


            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            string input = Console.ReadLine();
            //assign value to arrary grades at index 0
            grades[0] = int.Parse(input);
            Console.WriteLine("grades atr index 0 : {0}", grades[0]);
            

            // another way of initializing an array
            int[] gradesOfMathsStudentsA = { 20, 13, 45, 86 };

            // third way 
            int[] gradesOfMathsStudentB = new int[] { 20, 13, 45, 86, 20, 13, 45, 86 };

            Console.WriteLine("Length of gradesOfMathsStudentsA ; {0} ", gradesOfMathsStudentsA.Length);
            Console.ReadKey();

        }
    }
}
