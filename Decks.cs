namespace Arkham
{
	internal static class Decks
	{
		internal static Deck<MythosCard> Mythos = new Deck<MythosCard>(MythosDeckData.List);
		internal static Deck<CommonItem> Common = new Deck<CommonItem>(); //TODO: CommonDeckData
		internal static Deck<UniqueItem> Unique = new Deck<UniqueItem>();
		internal static Deck<Spell> Spell = new Deck<Spell>();
	}
}