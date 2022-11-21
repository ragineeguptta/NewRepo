using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    class Car
    {
        public int HP{ get; set; }
        public string Color { get; set; }

        //has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();
        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owener = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owener);
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }
        public Car()
        {

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
