using System;

namespace InheritanceDemo
{
    class Redio : ElectricalDevice
    {
        // chirld class
        public Redio(bool isOn, string brand):base(isOn, brand)
        {

        }


        //method to listen to the redio
        public void ListenRadio()
        {
            //first check if the radio is on 
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                //print error message
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}
