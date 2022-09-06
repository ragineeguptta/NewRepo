using System;

namespace opps1
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            // box.lenght = 3;
            box.SetLength(15);
            box.height = 4;
            box.width = 5;

            Console.WriteLine("Box lenght is " + box.GetLenght());

            Console.WriteLine("Box volumn is " + box.GetVolumn());
            box.DisplayInfo();

        }
    }
}
