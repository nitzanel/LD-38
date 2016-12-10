using System;

namespace AssemblyCSharp
{
	public class Enemy : Character
	{
		public Enemy (int money, int health, int damage, int level)
		{
			this.money = money;
			this.health = health;
			this.damage = damage;
			this.level = level;
			this.weapon = new Weapon ("basic", 10);
		}
	}
}

