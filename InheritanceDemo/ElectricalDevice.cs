using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class ElectricalDevice
    {
        public bool IsON { get; set; }

        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsON = isOn;
            Brand = brand;
        }

        public void SwitchOn()
        {
            IsON = true;
        }

        public void SwitchOff()
        {
            IsON  = false;
        }
    }
}
