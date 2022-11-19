using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOverrideDemo
{
    class Dog : Animal
    {
        //bool property to check if the dog is happy
        public bool IsHappy { get; set; }

        //simple constructor where we pass the name and age to our base constroctor
        public Dog(string name, int age) : base(name, age)
        {
            //all dogs are happy
            IsHappy = true;
        }

        //simple override of the virtual method Eat
        public override void Eat()
        {
            //to call the eat method from our base class we use the keyword "base"
            base.Eat();
        }

        //override of the virtual method MakeSound
        public override void MakeSound()
        {
            //since every animal make a tottaly diffrent sound
            //each animal will impliment their own version of Make Sound
            Console.WriteLine("Wuuuf!.");
        }

        public override void Play()
        {
            //check if the dog is happy if yes call the play method from the base
            // class
            if (IsHappy)
            {
                base.Play();
            }
            
        }
    }
}
