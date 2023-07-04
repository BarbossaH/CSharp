using System;

namespace Firstone
{
	public class ShapeCircle : ShapeCl
	{
		public double Radius { get; set; }

		public ShapeCircle(double radius)
		{
			Name = "Circle";
			Radius = radius;
		}

        public override double Area()
        {
			return Math.PI * (Math.Pow(Radius, 2.0));
        }

        public override void GetInfo()
        {
            base.GetInfo();
			Console.WriteLine($"It has a radius of {Radius}");
        }
    }
}

