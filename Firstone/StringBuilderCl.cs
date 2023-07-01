using System;
using System.Text;
using System.Globalization;

namespace Firstone
{
	public class StringBuildCL
	{
		static void Main1(string[] args)
		{
			StringBuilder sb = new StringBuilder("Random Text");
			StringBuilder sb2 = new StringBuilder("More people that is important", 256);
			//Console.WriteLine(sb);
			//Console.WriteLine("Capacity: {0}", sb2.Capacity); //256
			//Console.WriteLine("Length: {0}", sb2.Length); //29
			sb2.AppendLine(" more inportant text");
			Console.WriteLine(sb2);// connect the previous words
			CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
			string bestCust = "Bob Smith";
			sb2.AppendFormat(enUS, "Best Customer: {0}", bestCust);
			Console.WriteLine(sb2.ToString());
			sb2.Replace("text", "person");
            Console.WriteLine(sb2.ToString());
			sb2.Clear();  //clear the content of sb2, but the capacity is still 256
			sb2.Append("Julian is");
			Console.WriteLine(sb.Equals(sb2));  //true
			sb2.Insert(9, " I am a good person"); //this 9 is the length of "Julian is"
			Console.WriteLine(sb2);
			sb2.Remove(9, 5);
            Console.WriteLine(sb2);

        }
    }
}

