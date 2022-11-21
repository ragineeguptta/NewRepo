using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    //base class for furniture
    class Furniture
    {
        //color of the furniture
        public string Color { get; set; }
        //material of the furniture
        public string Material { get; set; }
        //default constructor
        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }

        //simple constructor
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
