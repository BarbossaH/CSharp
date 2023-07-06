using System;
namespace Firstone.Interface.smallgame
{
	public class Program
	{
		static void Main(string[] args)
		{
			MagicWarrior Julian = new MagicWarrior("Julian", 100, 26, 10,50);
			Warrior Fiona = new Warrior("Fiona", 120, 30, 10);
			Battle battle = new Battle();
			battle.StartFight(Julian, Fiona);
        }
	}
}

