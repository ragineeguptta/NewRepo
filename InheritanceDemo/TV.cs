using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
   // child
    class TV : ElectricalDevice
    {
        
        public TV(bool isOn, string brand):base(isOn, brand)
        {
           
        }

        //method to watch to the redio
        public void WatchTV()
        {
            //first check if the tv is on 
            if (IsOn)
            {
                //watch to tv
                Console.WriteLine("Watching TV!");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
