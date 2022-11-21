using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesC
{
    class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }
        public override double Volume()
        {
            return Math.PI * (Math.Pow(Radius, 3)) * 4 / 3;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThe Sphere has a Radius of {Radius}");
        }
    }
}
