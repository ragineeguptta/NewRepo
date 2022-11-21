using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ticket t1 = new Ticket(10);
            //Ticket t2 = new Ticket(10);
            //Console.WriteLine(t2.Equals(t1));


            //creating two objecta of type chair 
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            //creating a new object of type car
            Car damagedCar = new Car(80f, "Blue");

            //add the two chairs to the IDestriyable list of the car
            //so that when we destroyed the caar the destroyable objects
            //That are near the car will get destroyed as well
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            //destroy the car
            damagedCar.Destroy();
        }
    }
}
