using System;
namespace Firstone.Lambda
{
	public class Animal
	{
		public string Name { get; set; }
		public Animal( string name = "No name")
		{
			Name = name;
		}

		public Animal():this("No name") { }
	}
}

