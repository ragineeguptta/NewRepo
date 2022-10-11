using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Array
{
    class ArrayAsParameter
    {
        static void Main1(string[] args)
        {
            int[] studentsGrades = new int[] { 12, 32, 4, 1, 3, 12, 23 };
            double averageResult = GetAverage(studentsGrades);

            int[] happiness = { 2, 3, 4, 5, 6 };
            SunIsShining(happiness);

            foreach(int y in happiness)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();

            foreach(int grade in studentsGrades)
            {
                Console.WriteLine(" {0} ", grade);
            }

            Console.WriteLine("The average is: {0}", averageResult);
            Console.ReadKey();
        }

        static double GetAverage(int[] gradeArray)
        {
            int size = gradeArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i< size; i++)
            {
                sum += gradeArray[i];
            }
            average = (double)sum / size;
            return average;
        }
        static void SunIsShining(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] += 2;
        }
    }
}
