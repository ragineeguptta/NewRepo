using System;

namespace VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("sif", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} year old");
            dog.Play();
            dog.Eat();
            dog.MakeSound();
        }
    }
}
