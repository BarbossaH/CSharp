using System;
namespace Firstone
{
	public class Rectangle:ShapeCl
	{
		public double Len { get; set; }
		public double Wid { get; set; }
		public Rectangle(double len, double wid)
		{
			Name = "Rectangle";
			Len = len;
			Wid = wid;
		}

        public override double Area()
        {
			return Len * Wid;
        }

        public override void GetInfo()
        {
            base.GetInfo();
			Console.WriteLine($"It has a length of {Len} and width of {Wid}");
        }
    }
}

