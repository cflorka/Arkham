using System;
using System.Collections.Generic;

namespace Arkham
{
	internal partial class Investigator
	{
		List<Item> items = new List<Item>();
		List<Equipable> equipment = new List<Equipable>();

		internal void UseItem(Item item)
		{
			item.UseOn(this);
		}

		internal void TakeItem(Item item)
		{
			items.Add(item);
			Console.WriteLine(name + " got " + item.ToString());
		}

		internal void LoseItem(Item item)
		{
			items.Remove(item);
		}

		internal void Equip(Equipable item)
		{
			equipment.Add(item);
		}

		internal void Unequip(Equipable item)
		{
			equipment.Remove(item);
		}

		internal void Discard(Card card)
		{
			card.Discard();
			//TODO: Logic to remove from investigator
		}

		internal void DrawAndDiscardCommon(int numDraw, int numDiscard)
		{
			DrawAndDiscard(numDraw, numDiscard, Decks.Common);
		}

		internal void DrawAndDiscardUnique(int numDraw, int numDiscard)
		{
			DrawAndDiscard(numDraw, numDiscard, Decks.Unique);
		}

		internal void DrawAndDiscardSpell(int numDraw, int numDiscard)
		{
			DrawAndDiscard(numDraw, numDiscard, Decks.Spell);
		}

		private void DrawAndDiscard(int numDraw, int numDiscard, Deck<Item> deck)
		{
			List<Item> cardsKept = new List<Item>();
			Item drawnItem;
			for(int i = 0; i < numDraw; ++i)
			{
				drawnItem = deck.Draw();
				Console.WriteLine(name + " drew " + drawnItem.ToString());
				cardsKept.Add(drawnItem);
			}
			for(int i = 0; i < numDiscard; ++i)
			{
				Item discard = cardsKept[0]; //TODO: Choose card
				cardsKept.Remove(discard);
				discard.Discard();
			}
			foreach(Item item in cardsKept)
			{
				TakeItem(item);
			}
		}
		
		internal void UnexhaustItems() {foreach(Item i in items) i.UnExhaust();}
	}
}
