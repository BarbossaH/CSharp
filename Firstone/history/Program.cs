// See https://aka.ms/new-console-template for more information

namespace FirstApp
{
    public class FirstProgram
    {
        static void Main_1(string[] args) {

            //bool isVote = true;
            //Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            //Console.WriteLine("Biggest Integer : {0}", int.MinValue);
            //Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            //Console.WriteLine("Biggest Long : {0}", long.MinValue);
            //decimal delNumber = 0.333323232M;
            //Console.WriteLine("Biggest Decimal : {0}", decimal.MaxValue);
            //Console.WriteLine("Biggest Decimal : {0}", decimal.MinValue);
            //Console.WriteLine("Biggest double : {0}", double.MinValue);
            //Console.WriteLine("Biggest double : {0}", double.MaxValue);
            //double dNum = 0.444;
            //float fNum = 0.33f;
            //Console.WriteLine("Biggst Float :{0}", float.MaxValue);
            //Console.WriteLine("Smallest Float :{0}", float.MinValue);

            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.23");
            Console.WriteLine($"Data something: {boolFromStr.GetType()}--{intFromStr}--{dblFromStr}");

            string strVal = dblFromStr.ToString();
            Console.WriteLine($"{strVal}");
            Console.WriteLine($"{strVal.GetType()}");
            Console.WriteLine($"Integer :{(int)dblFromStr}");
            Console.WriteLine($"Integer :{(int)dblFromStr}");
        }
    }
}
