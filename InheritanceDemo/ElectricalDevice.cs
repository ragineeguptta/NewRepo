using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    //pparent class
    class ElectricalDevice
    {
        //boolean to determine the state of the ElectricalDevice
        public bool IsOn { get; set; }
        //string for the brand name of the ElectricalDevice
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        //switch on the ElectricalDevice
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch OFF the ElectricalDevice
        public void SwitchOff()
        {
            IsOn = false;
        }

    }
}
