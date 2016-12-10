using System;
using UnityEngine;
namespace AssemblyCSharp
{
	/// <summary>
	/// Character.
	/// </summary>
	public class Character
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssemblyCSharp.Character"/> class.
		/// </summary>
		public Character ()
		{
			this.inventory = new Inventory ();
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

		/// <summary>
		/// /Takes the item.
		/// </summary>
		/// <param name="giver_inventory">Giver inventory.</param>
		/// <param name="name">Name.</param>
		/// <param name="quantity">Quantity.</param>
		public void takeItem(Inventory giver_inventory, string name, int quantity)
		{
			if (giver_inventory.items.ContainsKey (name)) {
				int giver_quantity = giver_inventory.items [name].quantity;
				if (giver_quantity >= quantity) {
					giver_inventory.addItem (name, -quantity);
					this.inventory.addItem (name, quantity);
				} else {
					giver_inventory.addItem (name, -giver_quantity);
					this.inventory.addItem (name, giver_quantity);
				}
			}
			else
			{
				Debug.Log ("Requested item that doesnt exist");
			}
		}
		/// <summary>
		/// Takes the item.
		/// </summary>
		/// <param name="giver_inventory">Giver inventory.</param>
		/// <param name="item">Item.</param>
		public void takeItem(Inventory giver_inventory, Item item)
		{
			takeItem (giver_inventory, item.name, item.quantity);
		}



	}
}

