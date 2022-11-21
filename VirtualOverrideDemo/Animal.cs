using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOverrideDemo
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // is hungry boolean to check wether the animal is hungry
        public bool IsHungry { get; set; }


        //simple constroctor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            // in our case all our animals are hungry by default ;)
            IsHungry = true;
        }

        //an empty virtual method MakeSound for other classes to override
        public virtual void MakeSound()
        {

        }

        //a virtual method called Eat which sub classes can overridee
        public virtual void Eat()
        {
            //Check if animal is hungry
            if (IsHungry)
            {
                // if yes then print the name of animal + "is eating"
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                //otherwise print that the animal is not hungry
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        // virtual method Play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
