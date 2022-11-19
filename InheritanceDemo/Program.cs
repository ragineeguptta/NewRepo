using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Redio myRadio = new Redio(false,"Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            
            TV myTV = new TV(false, "Samsung");
            //method of parent class
            myTV.SwitchOn();
            // method of child class
            myTV.WatchTV();
        }
    }
}
