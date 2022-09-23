using System;

namespace _7_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare 2D Array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3 }, // row 0
                {4,5,6 }, // row 1
                {7,8,9 } // row 2
            };

            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.WriteLine("Central value is {0}", array2D[2, 0]);


            // 3 dimensional array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" }
                },
                {
                    {"100", "101" },
                    {"110", "111" }
                }
            };


            Console.WriteLine("The value is {0}", array3D[1,1, 0]);

            //2D string

            string[,] array2DString = new string[3, 2]
            {
                {"one", "two" },
                {"three", "four" },
                {"five", "six" }

            };

            array2DString[1, 1] = "chicken";

            //Rank return the amount of dimensions
            int dimensions = array2DString.Rank;

            //without specifying new things
            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("dimensions value is {0}", dimensions);
            Console.WriteLine("Central value is {0}", array2DString[1, 1]);
            Console.ReadKey();

        }

    }
}
