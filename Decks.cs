namespace Arkham
{
	internal static class Decks
	{
		internal static Deck<MythosCard> Mythos = new Deck<MythosCard>(MythosDeckData.List);
		internal static Deck<Item> Common = new Deck<Item>(); //TODO: CommonDeckData
		internal static Deck<Item> Unique = new Deck<Item>(); //TODO: UniqueDeckData
		internal static Deck<Item> Spell = new Deck<Item>(); //TODO: SpellDeckData
	}
}