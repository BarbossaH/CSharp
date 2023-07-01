using System;
namespace Firstone
{
	public class FunctionCl
	{
        //-------out-----------

        //static void DoubleIt(int x, out int solution)
        //{
        //	solution = x * 2;
        //}


        //-------ref-----------

        //public static void Swap(ref int a, ref int b)
        //{
        //    int tem = a;
        //    a = b;
        //    b = tem;
        //}

        //-------various parameter-----------
        //static double VariousParams(params double[] nums)
        //{
        //    double sum = 0;
        //    foreach(int i in nums)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}


        //-------overloading function-----------
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        static void PrintInfo(double i, double j)
        {
            Console.WriteLine("This is sum: {0}", (i + j));
        }

        static void PrintInfo(string i, string j)
        {
            double sum = Convert.ToDouble(j) + Convert.ToDouble(i);
            Console.WriteLine("This is tring : {0}", sum);
        }

        static void Main1(string[] args)
		{
            //-------out-----------
            //int solution;
            //DoubleIt(15, out solution);
            //Console.WriteLine("15 * 2 = {0}", solution);

            //-------ref-----------

            //         int num3 = 301;
            //int num4 = 401;
            //Console.WriteLine("Before :{0}, {1}", num3, num4);
            //         Swap(ref num3, ref num4);
            //         Console.WriteLine("After :{0}, {1}", num3, num4);

            //-------various parameter-----------
            //Console.WriteLine("1+2+3 : {0}", VariousParams(1, 2, 3, 4, 5));

            //-------overloading function-----------
            PrintInfo(zipCode: 1012, name: "Julian");
            PrintInfo(1, 2);
            PrintInfo("2", "4");
        }
    }
}

