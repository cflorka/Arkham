using System.Collections.Generic;

namespace Arkham
{
	internal class Card
	{
		string title;
		string body;
		
		internal Card(string title, string body)
		{
			this.title = title;
			this.body = body;
		}
		
		public override string ToString()
		{
			return title + ": " + body;
		}
	}

	internal class Item : Card
	{
		internal Item(string title, string body, int price)
			:base(title, body)
		{
			Price = price;
		}
		internal int Price{ get; set; }
	}

	internal class UniqueItem : Item
	{
		internal UniqueItem(string title, string body, int price) : base(title, body, price){}
	}
}
