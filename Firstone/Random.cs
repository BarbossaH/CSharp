using System;
namespace Firstone
{
	public class RandomClass
	{
		static void Mai1n(String[] arg)
		{
			Random rnd = new Random();
			int num = rnd.Next(1, 3);
			int gus = 0;
			Console.WriteLine("Number = {0}", num);
			int ok = 3;
			do
			{
				Console.WriteLine("Enter a number");
				gus = Convert.ToInt32(Console.ReadLine());

				Convert.ToString(ok);
			} while (num != gus);

		}
	}
}

