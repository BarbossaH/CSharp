using System;
using System.Collections;

namespace Firstone.ArrayListCL
{
	public class Program
	{
	static void Main(string[] args)
	{
            #region
            ArrayList alist = new ArrayList() ;
            alist.Add("One");
            alist.Add("two");
            alist.Add("three");
            alist.Add(4);

            //Console.WriteLine("Count: {0}", alist.Count);
            //Console.WriteLine("Capacity: {0}", alist.Capacity);

            ArrayList alist2 = new ArrayList();
            alist2.AddRange(new object[] { "a", "b", "c", "d" });
            alist.AddRange(alist2);
            alist2.Sort();

            //foreach(object o in alist2)
            //{
            //    Console.WriteLine(o);
            //}
            //foreach (object o in alist)
            //{
            //    Console.WriteLine(o);
            //}
            alist2.Reverse();
            alist.Reverse();
            alist.Insert(2,"Julian");
            alist.RemoveAt(0);
            alist.RemoveRange(2, 3);
            //foreach (object o in alist2)
            //{
            //    Console.WriteLine(o);
            //}
            foreach (object o in alist)
            {
                Console.WriteLine(o.GetType());
            }

            //the second param means from where to check
            //Console.WriteLine("sda {0}", alist.IndexOf("Julian",1));

            //convert the alish to a string type of array
            string[] a1 = (string[])alist.ToArray(typeof(string));
            foreach (object o in a1)
            {
                Console.WriteLine(o.GetType());
            }
            #endregion
        }
    }
}

