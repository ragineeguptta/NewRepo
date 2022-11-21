using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumeratorAndIEnumerable
{
    class Program
    {
        //1. IEnumerable <T> for generic collection
        //2. IEnumerable for non generic collection

        /// <summary>
        /// IEnumerable<T> contains a single method that you must implement when implementing this interface
        /// GetEnumerator(), which returns an IEnumerator<T> provides the ability to iterate through the collection
        /// The returned IEnumerator<T> provides the ability to iterate through the collecton
        /// by explosing a current property that points at the object we are currently at in collection.
        /// </summary>


        ///When it is recommentded to use the IEnumerable interface:
        ///- your collection represents a massive database table,
        ///you don't want to copy the entire things into memory and cause performance issues in your application.
        ///when it is not recommended to use the IEnumerable interface;
        ///you need the results right away and are possibly mutating / editing the objects later on.
        ///In this case, it is better to use an array or a list

        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }



    }

    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }

        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }
        //this method will print how many treats the dog receivved
        public void GiveTreat(int numberofTreats)
        {
            Console.WriteLine("Dog: {0} said wuoff {1} trimes!.", Name, numberofTreats);
        }
    }

    //a class named DogShellter this class contains a genric collection of type Dog
    //objects of this class can't be used inside a for each loop because it lacks an implementation of the IEnumerable interface
    class DogShelter : IEnumerable<Dog>
    {
        //list of type List<Dog>
        public List<Dog> dogs;
        //this constructor wil initialize the dogs list with some values
        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sir", true),
                new Dog("Rozy", false),
                new Dog("Pepppy", false),
                new Dog("Casper", false),
                new Dog("Zyn", true),
                new Dog("PIpa", true),
                new Dog("Gimmn", false),
                new Dog("Amy", true),
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        // we not use it because it is not generic
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
