//This is args test

namespace Firstone
{
    public class Program
    {
        static void Main(string[] args)
        {
            string theString = "This is a string";
            //Console.WriteLine("String Length : {0}", theString.Length);
            //Console.WriteLine("String Length : {0}", theString.Contains("is"));
            //Console.WriteLine("Index of is : {0}", theString.IndexOf("h"));
            //Console.WriteLine("Remove String : {0}", theString.Remove(10, 6));
            //Console.WriteLine("Insert String : {0}", theString.Insert(10, "short"));
            //Console.WriteLine("Replace String : {0}", theString.Replace("string","guy"));
            //Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));//-1 A preceeds B
            //Console.WriteLine("Compare A to B : {0}", String.Compare("B", "B", StringComparison.OrdinalIgnoreCase));//0
            //Console.WriteLine("Compare A to B : {0}", String.Compare("C", "B", StringComparison.OrdinalIgnoreCase)); //1
            //Console.WriteLine("A =a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("Pad left: {0}", theString.PadLeft(24, '.'));
            //Console.WriteLine("Pad right: {0}", theString.PadRight(20, '.'));
            //Console.WriteLine("Trim: {0}", theString.Trim());
            Console.WriteLine("UpperCase: {0}", theString.ToUpper());
            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Julian", "beautiful", "girl", "library");
            Console.Write(newString + "\n");  //   \'  \"  \\ \t \a
            Console.WriteLine(@"Exactly what I typed\n");
        }
    }
}