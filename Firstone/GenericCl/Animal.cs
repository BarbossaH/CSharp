using System;
namespace Firstone.GenericCl
{
	public class Animal
	{
		public string name { set; get; }
		public Animal(string name="No name")
		{
			this.name = name;
		}

		public static void GetSum<T>(ref T num1, ref T num2)
		{
			double x = Convert.ToDouble(num1);
			double y = Convert.ToDouble(num2);

			Console.WriteLine($"{x} + {y} = {x + y}");
		}
	}
}

