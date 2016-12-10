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


		public void takeItems(Inventory giver_inventory, string name, int quantity)
		{
			
		}
		public void takeItems(Inventory giver_inventory, Item item)
		{

		}



	}
}

