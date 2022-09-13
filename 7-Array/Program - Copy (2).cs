using System;

namespace _7_Array
{
    class Program_copy2
    {
        static void Main2(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            //for
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            //foreach
            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k); counter++;
            }


            //Create an array with 5 of your best friends
            //create a foreach loop which greets all of them


            string[] myFriend = { "aa", "bb", "cc", "dd", "ee" };
            foreach (string name in myFriend)
            {
                Console.WriteLine("Hello = {0}", name);
            }


            Console.ReadKey();

        }
    }
}
