using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Array
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            // Declare Jagged Array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 4, 5, 3, 5 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 12, 34 };


            //Aleternative Way
            int[][] jaggwdArray2 = new int[][]
            {
                new int [] {2,4,2,4,2 },
                new int[]{34,3,55 }
            };
            Console.WriteLine("The Value in the middle of the first entry is {0}", jaggwdArray2[0][2]);
            

            for(int i = 0; i < jaggwdArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggwdArray2[i].Length; j++)
                    Console.WriteLine("{0}", jaggwdArray2[i][j]);
            }

            Console.ReadKey();
        }
    }
}
