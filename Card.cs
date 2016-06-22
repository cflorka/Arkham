namespace Arkham
{
	internal enum CardType{Unique, Common, Skill, Spell, ArkhamEncounter, OtherWorldEncounter};
	
	internal class Card
	{
		CardType type;
		string title;
		string body;
		
		internal Card(CardType type, string title, string body)
		{
			this.type = type;
			this.title = title;
			this.body = body;
		}
		
		internal int Cost{ get; set; }
	}
	
	internal class UniqueItem : Card
	{
		internal UniqueItem(string title, string body)
			:base(CardType.Unique, title, body){}
	}
}
