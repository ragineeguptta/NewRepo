using System;

namespace loops
{
    class Program
    {
        static void Main1(string[] args)
        {
            //// for loop
            //for(int counter = 1; counter < 20; counter += 2)
            //{
            //    Console.WriteLine(counter);
            //}

            //// Do while loop
            //int lenghtOfText = 0;
            //string wholeText = "";
            //do
            //{
            //    Console.WriteLine("Please enter the name of your friend");
            //    string nameOfAFriend = Console.ReadLine();
            //    int currentLenght = nameOfAFriend.Length;
            //    lenghtOfText += currentLenght;
            //    wholeText += nameOfAFriend;
            //} while (lenghtOfText < 20);


            //Console.WriteLine("Thanks, that was enough! " + wholeText);

            //// While loop
            //int counter = 0;
            //string enteredText = "";
            //while (enteredText.Equals(""))
            //{
            //    Console.WriteLine("Please press enter to increase amount by one and anything else" +
            //        " + enter if you want to finish counting");
            //    enteredText = Console.ReadLine();

            //    counter++;
            //    Console.WriteLine("Current people count is {0}", counter);

            //}
            //Console.WriteLine("{0} people are inside the bus. Press enter to close the program", counter);


            //// break
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    if(i == 3)
            //    {
            //        Console.WriteLine("At 3 we stop!");
            //        break;
            //    }
            //}



            // continue
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Now comes Odd number!");
                    continue;
                }
                Console.WriteLine(i);
            }




            Console.Read();
        }


    }
}
