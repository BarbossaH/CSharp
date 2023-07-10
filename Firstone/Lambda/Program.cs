using System;
namespace Firstone.Lambda
{
	public class Program
	{
		delegate double doubleIt(double val);
	static void Main(string[] args)
		{
            #region
            //  key word: where

            //doubleIt all;
            //         doubleIt dbIt = x =>  { Console.WriteLine($"{x * 2}"); return x * 2; };
            //         doubleIt dbIt1 = x => { Console.WriteLine($"{x + 2}");  return x + 2; };
            //all = dbIt + dbIt1;
            //Console.WriteLine($"this is a test of lambda {all(3)}"); //5

            //List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var eventList = numList.Where(a => a % 2 == 0).ToList();

            //foreach(var e in eventList)
            //{
            //	Console.WriteLine(e);
            //}
            //var ranglist = numList.Where(x => x > 2 && x < 9).ToList();
            //foreach( var r in ranglist)
            //{
            //	Console.WriteLine(r);
            //}
            #endregion

            #region
            // key word:  where
            //List<int> flist = new List<int>();
            //int i = 0;
            //Random rnd = new Random();
            //while (i < 30)
            //{
            //    flist.Add(rnd.Next(1, 3));
            //    ++i;
            //}
            //Console.WriteLine("Head:{0}", flist.Where(a => a == 1).ToList().Count());
            //Console.WriteLine("Head:{0}", flist.Where(a => a == 2).ToList().Count());

            //var nameList = new List<string> { "Dog", "Snake", "Smith" };
            //var sName = nameList.Where(x => x.StartsWith("S"));
            ////var sName = nameList.Where(x => x.StartsWith("S")).ToList();
            //foreach (var n in sName) Console.WriteLine(n);
            #endregion

            #region
            //  key word: Select
            //var numList = new List<int>();
            //var sd = Enumerable.Range(1, 10);
            //foreach(var s in sd)
            //{
            //    //Console.WriteLine(s);
            //}
            ////Console.WriteLine(Enumerable.Range(1, 10));
            //numList.AddRange(Enumerable.Range(1, 10));
            //List<int> li = Enumerable.Range(1, 3).ToList();
            //var squares = numList.Select(x => x * x);
            //foreach(var s in li)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region
            // key word: Zip
            //var list1 = new List<int>(new int[] { 1, 2, 3 });
            //var list2 = new List<int>(new int[] { 4, 5, 6 });

            //var sumList = list1.Zip(list2, (x, y) => x + y).ToList();
            //Console.WriteLine("the type is {0}", sumList.GetType());
            //foreach(var s in sumList)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region
            // key word: Aggregate Average All Any Distinct
            //var numList = new List<int>() { 1, 2,3,5,6,7,2, 3 };
            //Console.WriteLine("Sum = {0}", numList.Aggregate((a, b) => a + b));
            //Console.WriteLine("Avg = {0}", numList.AsQueryable());
            //Console.WriteLine("Avg = {0}", numList.AsQueryable().Average());
            //Console.WriteLine("Avg > 1: {0}", numList.All(x=>x>1));
            //Console.WriteLine("Avg > 1: {0}", numList.Any(x=>x>1));
            //Console.WriteLine("Distict: {0}", string.Join(", ", numList.Distinct()));
            //var numlist2 = new List<int> { 3,2 };
            //Console.WriteLine("Except: {0}", string.Join(", ", numList.Except(numlist2)));
            //Console.WriteLine("Intersect: {0}", string.Join(", ", numList.Intersect(numlist2)));
            #endregion
            #region
            // key word: IEnumerable
            //string[] names = { "Dog", "Pig", "Chicken", "Cow", "Sheep" };
            //AnimalFarm animalFarm = new AnimalFarm();
            //for(int i=0;i<names.Length;i++)
            //{
            //    animalFarm[i] = new Animal(names[i]);
            //    Console.WriteLine(animalFarm[i].Name);
            //}
            #endregion
            #region
            //  key word: operator overidding
            //Box box = new Box(2, 3, 4);
            //Box box2 = new Box(12, 13, 14);
            //Box box3 = box+box2;
            //Box box11 = 3;
            //Box box12 = (Box)6;
            //Console.WriteLine(box3.ToString());
            //Console.WriteLine(box11.ToString());
            //Console.WriteLine(box12.ToString());
            #endregion

            #region
            // key word: anonymous types
            var Shopkins = new { Name = "Shopkins", Price = 4.99 };
            Console.WriteLine("{0} cost ${1}", Shopkins.Name, Shopkins.Price);

            var grocery = new[]
            {
                new {Name="Food", Price=0.99},
                new {Name="Tool", Price=1.99},
                new {Name="Vehicle", Price=14.99}
            };

            foreach(var item in grocery)
            {
                Console.WriteLine("{0} is ${1}", item.Name, item.Price);
            }
            #endregion


        }
    }
}

