﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace AssemblyCSharp
{
	/// <summary>
	/// Inventory.
	/// </summary>
	public class Inventory : ScriptableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssemblyCSharp.Inventory"/> class.
		/// </summary>
		public Inventory ()
		{
		}
		/// <summary>
		/// The items.
		/// </summary>
		public Dictionary<string,Item> items = new Dictionary<string,Item>();

		/// <summary>
		/// Adds the item to the dictionary, or increase the quantity.
		/// Can make the quantity go below 0.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="quantity">Quantity.</param>
		/// <param name="price">Price.</param>
		public void addItem(string name, int quantity, int price = 0)
		{
			if (this.items.ContainsKey(name))
			{
				this.items [name].quantity += quantity;
			}
			else
			{
				this.items.Add (name, new Item (name, quantity, price));
			}
		
		}

		/// <summary>
		/// Adds the item.
		/// </summary>
		/// <param name="item">Item.</param>
		public void addItem(Item item)
		{
			this.addItem (item.name, item.quantity, item.price);
		}


	}
}

 