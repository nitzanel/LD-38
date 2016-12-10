using System;

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
			
		}
		/// <summary>
		/// Takes the item.
		/// </summary>
		/// <param name="giver_inventory">Giver inventory.</param>
		/// <param name="item">Item.</param>
		public void takeItem(Inventory giver_inventory, Item item)
		{

		}



	}
}

