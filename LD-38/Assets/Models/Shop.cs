using System;
using UnityEngine;

namespace AssemblyCSharp
{
	/// <summary>
	/// Shop.
	/// </summary>
	[Serializable]
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

