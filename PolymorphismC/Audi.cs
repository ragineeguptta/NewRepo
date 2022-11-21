using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + "HP: " + HP + " Color:" + Color);
        }
        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Model);
        }
    }
}
