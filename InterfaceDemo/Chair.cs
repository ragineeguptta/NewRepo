using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Chair : Furniture, IDestroyable
    {
        //implementing the interface's property
        public string DestructionSound { get; set; }
        //simple constructor
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }
        //implement the interface's method
        public void Destroy()
        {
            //when a chair gets destroyed we should play the destruction sound
            //and spawn the destroyed chari parts
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Spawning chair parts");
        }

    }
}
