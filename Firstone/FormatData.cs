﻿using System;
namespace Firstone
{
	public class FormatData
	{
		static void Main(string[] arg)
		{
			Console.WriteLine("Currency : {0:c}", 23.323223);
			Console.WriteLine("Pad with 0s : {0:d4}",33);
			Console.WriteLine("3 Decimals : {0:f4}", 23.1234567);
			Console.WriteLine("Commas : {0:n4}", 3300);
			Console.WriteLine("Commas : {0} is {1} ", "My name","Julian");
        }
	}
}
