using System.Collections.Generic;

namespace Arkham
{
	internal enum ItemType{Common, Unique, Spell}

	internal abstract class Item : Card
	{
		private ItemType type;
		private bool isExhausted;
		
		internal Item(ItemType type, string title, string body, int price)
			:base(title, body)
		{
			Price = price;
			this.type = type;
			isExhausted = false;
		}
		internal int Price{ get; set; }
		internal ItemType Type{ get{return type;} }
		internal abstract void UseOn(Investigator i);
		internal override abstract void Discard();
		internal bool IsExhausted{get{return isExhausted;}}
		internal void Exhaust(){isExhausted = true;}
		internal void UnExhaust(){isExhausted = false;}
	}

	internal abstract class UniqueItem : Item
	{
		internal UniqueItem(string title, string body, int price) : base(ItemType.Unique, title, body, price){}
		internal override abstract void UseOn(Investigator i);
		internal override void Discard() {Decks.Unique.AddToBottom(this);}
	}

	internal abstract class CommonItem : Item
	{
		internal CommonItem(string title, string body, int price) : base(ItemType.Common, title, body, price){}
		internal override abstract void UseOn(Investigator i);
		internal override void Discard() {Decks.Common.AddToBottom(this);}
	}

	internal abstract class Spell : Item
	{
		internal Spell(string title, string body, int price) : base(ItemType.Spell, title, body, price){}
		internal override abstract void UseOn(Investigator i);
		internal override void Discard() {Decks.Spell.AddToBottom(this);}
	}

	internal interface Equipable
	{
		int Hands{get;}
	}
}