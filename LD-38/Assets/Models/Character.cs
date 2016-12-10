using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class Character
	{
		public Character ()
		{
			this.inventory = new Inventory ();
			this.money = 1000;
		
		}

		public Inventory inventory;
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
			int giver_quantity = giver_inventory.items [item.name].quantity;
			if (giver_quantity >= item.quantity)
			{
				giver_inventory.addItem (item.name, -item.quantity);
				this.inventory.addItem (item.name, item.quantity);
			}
			else
			{
				giver_inventory.addItem (item.name, -giver_quantity);
				this.inventory.addItem (item.name, giver_quantity);
			}
		}



	}
}

