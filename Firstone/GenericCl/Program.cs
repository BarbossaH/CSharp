using System;
namespace Firstone.GenericCl
{
	public class Program
	{
	static void Main1(string[] args)
	{
            #region
            List<Animal> animals = new List<Animal>();

			List<int> numList = new List<int>();

			numList.Add(24);

			animals.Add(new Animal() { name = "A" });
			animals.Add(new Animal() { name = "B" });
			animals.Add(new Animal() { name = "C" });

			animals.Insert(1, new Animal() { name = "1" });
			foreach(Animal a in animals)
			{
				//Console.WriteLine(a.name);
			}
			animals.RemoveAt(1);
            foreach (Animal a in animals)
            {
                //Console.WriteLine(a.name);
            }

			int x = 3;
			int y = 6;
			Animal.GetSum<int>(ref x, ref y);
			string sx = "4";
			string sy = "5";
			Animal.GetSum<string>(ref sx, ref sy);

			Rectangle<int> r1 = new Rectangle<int>(x, y);
			//Console.WriteLine("The area is {0}", r1.GetArea());

			Arthemtic add, sub, addSub;
			add = new Arthemtic(Add);
			sub = new Arthemtic(Sub);
			addSub = add + sub;

			Console.WriteLine($"Add & Subtract {10} and {4}");
			addSub(10, 4);
        }
        #endregion

        public struct Rectangle<T>
        {
			private T width;
			private T length;

			public T Width
			{
				get { return width; }
				set { width = value; }
			}
			public T Length { get { return length; }
				set { length = value; } }
			public Rectangle(T w, T l)
			{
				width = w;
				length = l;
			}

			public string GetArea()
			{
				double dw = Convert.ToDouble(Width);
				double dl = Convert.ToDouble(Length);
				return string.Format($"{dw} * {dl}={dw * dl}");
			}
        }

		public delegate void Arthemtic(double x, double y);

		public static void Add(double x, double y)
		{
			Console.WriteLine($"x + y = {x + y}");
		}
        public static void Sub(double x, double y)
        {
            Console.WriteLine($"x - y = {x - y}");
        }
    }
}

