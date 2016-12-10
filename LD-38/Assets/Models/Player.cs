using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Player.
	/// </summary>
	public class Player : Character
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssemblyCSharp.Player"/> class.
		/// </summary>
		public Player ( int money, int health, int damage, int level)
		{
			this.money = money;
			this.health = health;
			this.damage = damage;
			this.level = level;
			this.weapon = new Weapon ("basic", 10);
		}



	}
}

