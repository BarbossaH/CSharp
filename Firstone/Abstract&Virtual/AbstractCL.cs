using System;
namespace Firstone
{
	public class AbstractCL
	{
	static void Main1(string[] argd)
		{
			ShapeCl[] shapes = { new ShapeCircle(5), new Rectangle(2, 3) };

			foreach( ShapeCl s in shapes)
			{
				s.GetInfo();

				Console.WriteLine("{0} Area: {1:f2}", s.Name, s.Area());

				ShapeCircle testC = s as ShapeCircle;
				if( testC == null)
				{
					Console.WriteLine("This is Rectangle");
				}
				if (s is ShapeCircle)
				{
					Console.WriteLine("This is a circle123");
				}
			}
			object obj = new ShapeCircle(3);
			ShapeCircle obj2 = (ShapeCircle)obj;
			Console.WriteLine("{0} Area is {1:f2}", obj2.Name, obj2.Area());
		}
	}
}

