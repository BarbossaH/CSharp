using System;
namespace Firstone
{
	abstract class ShapeCl
	{
		public string Name { get; set; }

		public virtual void GetInfo()
		{
			Console.WriteLine($"This is my name {Name}");
		}

		public abstract double Area();
	}
}

