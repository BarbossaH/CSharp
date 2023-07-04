using System;
namespace Firstone
{
	public class ProgramInterface
	{
	static void Main(string[] args)
		{
			Vechicle vechicle = new Vechicle("R", 4, 160);
			if(vechicle is IDrivable)
			{
				((IDrivable)vechicle).Move();
				((IDrivable)vechicle).Stop();
			}
			else {
				Console.WriteLine("The {0} can't be driven", vechicle.Brand);
			}

		}
	}
}

