using System;
namespace Firstone
{
    public class Televsion : IElectrionicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("The Tv is off");
        }

        public void On()
        {
            Console.WriteLine("The Tv is on");

        }

        public void VolumeDown()
        {
            if (Volume > 0) Volume--;
            Console.WriteLine("The Tv is VolumeDown");

        }

        public void VolumeUp()
        {
            if (Volume < 100) Volume++;

            Console.WriteLine("The Tv is VolumeUp");

        }
    }
}

