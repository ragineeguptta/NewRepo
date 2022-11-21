using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Car : Vehical, IDestroyable
    {
        //implementing the interface's properties
        public string DestructionSound { get; set; }

        //creating a new property to store the destroyable objects nearby
        //when a car gets destroyd it should also destroy the nearby object
        //this list is of type IDestroyable which means it can store any object
        //that implements this interface and we can only access the propeties and
        // method in this interface

        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            //initialize theinterface's property with a value in the constructore
            DestructionSound = "CarExplosionSound.mp3";
            //initialize the list of destroyable objects
            DestroyablesNearby = new List<IDestroyable>();
        }

        //implement the interface's method
        public void Destroy()
        {
            //When a car gets destroyed we should play the destruction sound
            //and create fire effect
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            //go through each destroyable object nearby and call it's destroy method
            foreach(IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
        
    }
}
