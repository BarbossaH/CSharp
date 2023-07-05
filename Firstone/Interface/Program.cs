using System;
namespace Firstone
{
	public class ProgramInterface
	{
	static void Main1(string[] args)
		{
			//Vechicle vechicle = new Vechicle("R", 4, 160);
			//if(vechicle is IDrivable)
			//{
			//	((IDrivable)vechicle).Move();
			//	((IDrivable)vechicle).Stop();
			//}
			//else {
			//	Console.WriteLine("The {0} can't be driven", vechicle.Brand);
			//}

			IElectrionicDevice TV = TVRmote.GetDevice();

			PowerButtom pwBtn = new PowerButtom(TV);
			pwBtn.Execute();
			pwBtn.Undo();

		}
	}
}

/*
 *  there are two interfaces inherited by tv and powerbutton, and
 *  tv has several functions, the instance of tv can call them
 *  powerbuttion has an attribute name device, which could be tv
 *  there is a tvromove to offer a function to generate a tv object
 *  so the main function is to create a button instance and intialized.
 *  and then call the tv's function
 */
