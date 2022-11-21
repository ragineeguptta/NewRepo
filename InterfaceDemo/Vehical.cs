using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Vehical
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        public Vehical()
        {
            Speed = 120f;
            Color = "White";
        }
        public Vehical(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
