using System;
namespace Firstone
{
	public class ArrayClass
	{
		static void PrintArr(int[] array, string msg)
		{
			foreach(int k in array)
			{
				Console.WriteLine("{0} : {1}", msg, k);
			}
		}

	static void Main(String[] arg)
		{
			//int[] ints = new int[3];
			//ints[0] = 123;
			////Console.WriteLine("Ints[0] = {0}", ints[0]);
			//String[] strings = { "A", "B", "C" };
			//var em = new[] { "1", "3", "5" };
			//object[] obj = { "Paul", 1, 2 };
			////Console.WriteLine("Obj 0: {0}", obj[0]);
			////Console.WriteLine("Array's size: {0}", obj.Length);

			//for(int j=0; j < obj.Length; j++)
			//{
			//	Console.WriteLine("Array-{0} is equal to {1}", j, obj[j]);
			//}

			//string[,] cs = new string[2, 2] { { "Julian", "Address" }, { "Fiona", "Eden" } };
			//Console.WriteLine("MD value is {0} and {1}", cs[0, 0], cs.GetValue(1,0));

			//int[] arrays = { 1, 32, 23, 14, 25 };
			//         //PrintArr(arrays, "Foreach");
			//         Array.Sort(arrays);
			//Array.Reverse(arrays);
			//Console.WriteLine("Sorted {0}", arrays[0]);

			//         int[] sourceArray = { 1, 2, 3, 4, 5 };
			//         int[] destinationArray = new int[5];

			//         int length = 3;
			//         int startIndex = 1;
			//         int destinationIndex = 2;

			//         Array.Copy(sourceArray, startIndex, destinationArray, destinationIndex, length);
			////PrintArr(destinationArray, "Copy");
			//Array anotherArray = Array.CreateInstance(typeof(int), 10);
			//sourceArray.CopyTo(anotherArray, 3);
			//foreach(int m in anotherArray)
			//{
			//	Console.WriteLine("Copy to :{0}", m);
			//}

			int[] numArr = { 1, 11, 22 };
			Console.WriteLine(">10 : {0}", Array.Find(numArr, num => num > 10));
        }
    }
}

