using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    interface IDestroyable
    {
        //property to store the audio file of the destruction sound
        string DestructionSound { get; set; }

        //method to destroy an object
        void Destroy();
    }
}
