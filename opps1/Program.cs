using System;

namespace opps1
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);
            //// box.lenght = 3;
            //box.SetLength(15);
            //box.Height = -5;
            //box.Width = 5;

            Console.WriteLine("Box lenght is " + box.GetLenght());

            Console.WriteLine("Box volumn is " + box.Volume);
            Console.WriteLine("Box volumn is " + box.GetVolumn());
            box.DisplayInfo();

        }
    }
}
