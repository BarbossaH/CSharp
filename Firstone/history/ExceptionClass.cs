using System;
namespace Firstone
{
	public class ExceptionClass
	{
		static double DoDision(double x, double y)
		{
			if (y == 0)
			{
				throw new System.DivideByZeroException();
			}
			return x / y;
		}
		static void Main1(string[] arg)
		{
			double num1 = 4;
			double num2 = 0;
			try
			{
				Console.WriteLine("5 / 0 = {0}", DoDision(num1, num2));
			}
			catch (DivideByZeroException ex){
				Console.WriteLine("You cannot divide by zero");
				Console.WriteLine(ex.GetType().Name);
				Console.WriteLine(ex.Message);
            }
			catch(Exception ex)
			{
				Console.WriteLine("Error");
				Console.WriteLine("Error", ex.GetType().Name);
				Console.WriteLine("Error", ex.Message);
            }
			finally
			{
				Console.WriteLine("Cleaning up");
			}
		}
	}
}

