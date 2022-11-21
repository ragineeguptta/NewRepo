using System;
using System.Collections.Generic;
using System.Text;

namespace IEnumeratorAndIEnumerable
{
    class IEnumerableExample1
    {
        static void Main1(string[] args)
        {
            //creating a genric IEnumerable variable that takes any collection of type int
            //we will use this variable to store the collections that will get returned by the GetCollection/90 method
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            //foreach number in the collection we got back from GetCollection(1);
            foreach (int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }


            //new line
            Console.WriteLine("");
            //call GetCollection() with option = 2 which will return a Queue<int>
            //but we will store it in the base type of generic collections
            unknownCollection = GetCollection(2);

            Console.WriteLine("This was a Queue<int>");
            //for each number in the collection we got back from GetCollection(2);
            foreach (int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }

            //new line
            Console.WriteLine("");
            //call GetCollection() with option = 5 which will return an array int[]
            //but we will store it in the base type of generic collections
            unknownCollection = GetCollection(5);

            Console.WriteLine("This was an array of int");
            //for each number in the collection we got back from GetCollection(2);
            foreach (int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }
        }

        static IEnumerable<int> GetCollection(int option)
        {
            //create a list of number and initialize it
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, };

            Queue<int> numbersQueue = new Queue<int>();
            //add values to the queue
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            //if the option is 1
            if(option == 1)
            {
                //return the list of type List<int>
                return numberList;
                //if the option is 2
            }
            else if (option == 2)
            {
                //return the queue of type List<int>
                return numbersQueue;
                //otherwwise
            }
            else
            {
                //return an array
                return new int[] { 11, 12, 13, 14, 15 };
            }

        }
    }
}
