using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Radio : ElectricalDevice

    {
        public Radio(bool isOn, string brand): base(isOn, brand)
        {
            IsON = isOn;
            Brand = brand;
        }

        public void ListenRadio()
        {
            if (IsON)
            {
                Console.WriteLine("Listening to radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}
