using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    class Car
    {
        public int HP{ get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: "+ HP + " Color:" + Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
