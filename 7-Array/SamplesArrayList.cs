using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _7_Array
{
    class SamplesArrayList
    {
        static void Main(string[] args)
        {
            // declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            // declaring an ArrayList with defined amount of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(25);
            myArrayList.Add(25);
            myArrayList.Add(25);
            myArrayList.Add(25);
            myArrayList.Add(25);


            // delete element with specific value from the arrayList
            myArrayList.Remove(13);

            // declare element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}
