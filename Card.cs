namespace Arkham
{
	enum CardType{Unique, Common, Skill, Spell, ArkhamEncounter, OtherWorldEncounter};

	public class Card
	{
		CardType type;
		String title;
		String body;
		
		public Card(CardType type, String title, String body)
		{
			this.type = type;
			this.title = title;
			this.body = body;
		}
		
		public int Cost{ get; set; }
	}
	
	public class UniqueItem : Card
	{
		
	}
}
