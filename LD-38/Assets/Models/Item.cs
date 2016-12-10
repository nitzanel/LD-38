using System;

namespace AssemblyCSharp
{
	public class Item
	{	
		// constructor
		public Item (string name, int quantity, int price)
		{
			this->name = name;
			this->quantity = quantity;
			this->price = price;
		}
		// name of the item
		string name;
		// quantity of the item
		int quantity;
		// price for 1 piece of the item
		int price;
	}
}

