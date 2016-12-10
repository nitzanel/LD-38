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
			
		}
		/// <summary>
		/// The inventory.
		/// </summary>
		public Inventory inventory = new Inventory();
		/// <summary>
		/// The money.
		/// </summary>
		public int money = 100000;
	}
}

