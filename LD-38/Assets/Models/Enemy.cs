using System;

namespace AssemblyCSharp
{
	[System.Serializable]
	public class Enemy : Character
	{
		public bool hostile;

		public Enemy ()
		{
			this.name = "Default name";
			this.money = 0;
			this.health = 1;
			this.level = 1;
			this.weapon = new Weapon ("default", 0);
			this.hostile = true;
		}
		public Enemy (string name,int money, int health,int damage, int level, bool hostile)
		{
			this.name = name;
			this.money = money;
			this.health = health;
			this.level = level;
			this.weapon = new Weapon ("basic", damage);
			this.hostile = hostile;
		}
	}
}

