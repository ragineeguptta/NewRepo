using System;
using System.Collections.Generic;
using System.Text;

namespace opps1
{
    class Box
    {
        //member variable
        private int lenght = 3;
        public int height;
        public int width;
        public int volume;


        public void SetLength(int lenght)
        {
            this.lenght = lenght;
        }

        public int GetLenght()
        {
            return this.lenght;
        }

        public int GetVolumn()
        {
            return this.lenght*this.height*this.width;
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so volumn is {3}", lenght, height, width, volume = lenght*height*width);
        }

    }
}
