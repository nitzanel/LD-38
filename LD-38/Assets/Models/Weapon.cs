using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Weapon.
	/// </summary>
	public class Weapon
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssemblyCSharp.Weapon"/> class.
		/// </summary>
		public Weapon (string name, int damage)
		{
			this.damage = damage;
			this.name = name;
		}

		public int damage;
		public string name;
	}
}

