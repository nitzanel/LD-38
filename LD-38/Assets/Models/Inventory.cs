using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Inventory
	{
		public Inventory ()
		{
			// the dictionary of items
			items = new Dictionary<string,Item>();
		
		}
		public Dictionary<string,Item> items;

		/// <summary>
		/// Adds the item to the dictionary, or increase the quantity.
		/// Can make the quantity go below 0.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="quantity">Quantity.</param>
		/// <param name="price">Price.</param>
		public void add_item(string name, int quantity, int price = 0)
		{
			if (items.ContainsKey(name))
			{
				items [name].quantity += quantity;
			}
			else
			{
				items.Add (name, new Item (name, quantity, price));
			}
		
		}



	}
}

 