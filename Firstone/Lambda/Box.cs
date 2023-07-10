using System;
namespace Firstone.Lambda
{
	public class Box
	{
		public double Width { get; set; }
		public double Length { get; set; }
		public double Breadth { get; set; }

		public Box()
			: this(1, 1, 1) { }
		public Box(double length, double width, double breadth)
		{
			Length = length;
			Width = width;
			Breadth = breadth;
		}

		public static Box operator +(Box box1, Box box2)
		{
			Box newBox = new Box()
			{
				Length = box1.Length + box2.Length,
				Width = box1.Width + box2.Width,
				Breadth = box1.Breadth + box2.Breadth
			};

			return newBox;
		}


        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };

            return newBox;
        }

        public static bool operator ==(Box box1, Box box2)
        {
			if (box1.Breadth == box2.Breadth && box1.Length == box2.Length && box1.Width == box2.Width) return true;

            return false;
        }
        public static bool operator !=(Box box1, Box box2)
        {
            if (box1.Breadth != box2.Breadth || box1.Length != box2.Length || box1.Width != box2.Width) return true;


            return false;
        }

        public override string ToString()
        {
            return String.Format("Box with height: {0} Width : {1} and Breadth : {2} ", Length, Width,Breadth);
        }

        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }
    }
}

