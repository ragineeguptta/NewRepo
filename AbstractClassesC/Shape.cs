using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesC
{
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        public abstract double Volume();
    }
}
