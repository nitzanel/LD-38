using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Shop.
	/// </summary>
	public class Shop
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssemblyCSharp.Shop"/> class.
		/// </summary>
		public Shop ()
		{
			this.inventory = new Inventory();
			this.money = 1000;
		}
		/// <summary>
		/// The inventory.
		/// </summary>
		public Inventory inventory;
		/// <summary>
		/// The money.
		/// </summary>
		public int money;
	}
}

