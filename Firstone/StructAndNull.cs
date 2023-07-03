using System;
using Firstone;

namespace Firstone
{
	public class StructAndNull
	{
        public double? a = null;
        public readonly int read = 1;
        struct Rectangle
        {

            public double length;
            public double width;
            public Rectangle(double l=1, double w = 1) { length = l; width = w; }
            public double Area()
            {
                return length * width;
            }
        }
        static void Main(string[] args)
		{
            Rectangle rr1;
            rr1.length = 18;
            rr1.width = 2;
            Console.WriteLine("Area of r1: {0}", rr1.Area());
            Rectangle r2 = new Rectangle(22, 2);
            Console.WriteLine("Before R2:{0}", r2.Area());
            r2 = rr1;
            rr1.length = 33;
            Console.WriteLine("R2.length {0}", r2.length);
            Console.WriteLine("After R2.area {0}", r2.Area());
        }
	}

   class Animal
    {
        string name;
        string sound;

        public Animal() : this("No name", "No sound") { }
        public Animal(string name) : this(name, "No sound") { }
        public Animal(string name, string sound) { }
    }
}



