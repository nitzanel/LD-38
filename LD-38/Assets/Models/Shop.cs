using System;

namespace AssemblyCSharp
{
	public class Shop
	{
		public Shop ()
		{
			this.inventory = new Inventory();
		}
		public Inventory inventory;
	}
}

