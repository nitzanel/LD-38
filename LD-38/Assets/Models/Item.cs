using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Item.
	/// </summary>
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
			this.name = name;
			this.quantity = quantity;
			this.price = price;
		}
		// name of the item
		public string name {get; set;}
		// quantity of the item
		public int quantity {get; set; }
		// price for 1 piece of the item
		public int price {get; set;}

		// SOME NEW INFORMATION

	}
}

