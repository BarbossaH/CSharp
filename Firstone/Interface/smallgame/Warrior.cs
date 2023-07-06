using System;
namespace Firstone.Interface.smallgame
{
	public class Warrior
	{
		Random rnd = new Random();
		public string warriorName { get; set; }
		public double healthMax{ get; set; }
        public double attackMax { get; set; }
        public double blockMax { get; set; }

		public Warrior(string name="Julian",double health=0, double attack=0, double block=0)
		{
			warriorName = name;
			healthMax = health;
			attackMax = attack;
			blockMax = block;
		}

		// the final attack value
		public double Attack()
		{
			return rnd.Next(1,(int)attackMax);
		}
		//the final block value
		public virtual double Block()
		{
			return rnd.Next(1, (int)(blockMax));
		}
	}
}

