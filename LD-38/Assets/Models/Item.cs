using System;

namespace AssemblyCSharp
{
	public class Item
	{	
		/// <summary>
		/// Initializes a new instance of the <see cref="AssemblyCSharp.Item"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="quantity">Quantity.</param>
		/// <param name="price">Price.</param>
		public Item (string name, int quantity, int price)
		{
			this->name = name;
			this->quantity = quantity;
			this->price = price;
		}
		// name of the item
		string name {get; set;}
		// quantity of the item
		int quantity {get; set; }
		// price for 1 piece of the item
		int price {get; set;}

		// SOME NEW INFORMATION

	}
}

