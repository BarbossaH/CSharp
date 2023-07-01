using System;
namespace Firstone
{
	public class DataTime
	{
		static void Main(string[] args)
		{
			DateTime awesomeDate = new DateTime(1981, 06, 22);
			Console.WriteLine("Day of the week:{0}", awesomeDate.DayOfWeek);

			awesomeDate = awesomeDate.AddDays(4);
			Console.WriteLine("New Date:{0}", awesomeDate.Date);
            awesomeDate = awesomeDate.AddMonths(12);
            Console.WriteLine("New Date:{0}", awesomeDate.Date);
			awesomeDate = awesomeDate.AddYears(20);
			Console.WriteLine("New Date:{0}", awesomeDate.Date);

			TimeSpan timeSpan = new TimeSpan(12, 30, 0);
			Console.WriteLine("New Time:{0}", timeSpan);
			timeSpan = timeSpan.Subtract(new TimeSpan(0, 15, 0));
			Console.WriteLine("New Time:{0}", timeSpan.ToString());
        }
	}
}

