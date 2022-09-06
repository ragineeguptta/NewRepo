using System;
using System.Collections.Generic;
using System.Text;

namespace opps1
{
    class Box
    {
        //member variable
        private int lenght = 3;
        private int height;
       // public int width;
        private int volume;


        public int Width { get; set; }

        public int Volume
        {
            get
            {
                return this.lenght * this.height * this.Width;
            }
        }

        public Box(int length, int height, int width)
        {
            this.lenght = length;
            this.height = height;
            Width = width;

        }


        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

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
            return this.lenght*this.height*this.Width;
        }


        public int FrontSurface
        {
            get { return height * lenght; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so volumn is {3}", lenght, height, Width, volume = lenght*height*Width);
        }

    }
}
