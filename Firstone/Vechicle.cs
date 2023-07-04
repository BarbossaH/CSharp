using System;
namespace Firstone
{
	public class Vechicle:IDrivable
	{
		public string Brand { get; set; }

		public Vechicle(string brand = "Np Brand", int wheels = 0, double speed=0)
		{
			Brand = brand;
			Wheels = wheels;
			Speed = speed;
		}

		public double Speed { get; set; }
		public int Wheels { get; set; }

		public void Move()
		{
			Console.WriteLine($"The {Brand} Moves Forward at {Speed} MPH");
		}
		public void Stop()
		{
            Console.WriteLine($"The {Brand} Stop at {Speed} MPH");
			Speed = 0;
        }
    }
}

