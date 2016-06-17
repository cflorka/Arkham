namespace Arkham
{
	internal class MiskatonicU:Street
	{
		private static readonly MiskatonicU instance = new MiskatonicU();

		static MiskatonicU(){}
		private MiskatonicU():base("Miskatonic University"){}
		public static MiskatonicU Instance { get { return instance; } }
	}

	internal class AdminBuilding:CityLocation
	{
		private static readonly AdminBuilding instance = new AdminBuilding();

		static AdminBuilding(){}
		private AdminBuilding():base("Administration Building"){}
		public static AdminBuilding Instance { get { return instance; } }
	}

	internal class ScienceBuilding:CityLocation
	{
		private static readonly ScienceBuilding instance = new ScienceBuilding();

		static ScienceBuilding(){}
		private ScienceBuilding():base("Science Building"){}
		public static ScienceBuilding Instance { get { return instance; } }
	}

	internal class Library:CityLocation
	{
		private static readonly Library instance = new Library();

		static Library(){}
		private Library():base("Library"){}
		public static Library Instance { get { return instance; } }
	}

	internal class Uptown:Street
	{
		private static readonly Uptown instance = new Uptown();

		static Uptown(){}
		private Uptown():base("Uptown"){}
		public static Uptown Instance { get { return instance; } }
	}

	internal class Hospital:CityLocation
	{
		private static readonly Hospital instance = new Hospital();

		static Hospital(){}
		private Hospital():base("St. Mary's Hospital"){}
		public static Hospital Instance { get { return instance; } }
	}

	internal class Woods:CityLocation
	{
		private static readonly Woods instance = new Woods();

		static Woods(){}
		private Woods():base("Woods"){}
		public static Woods Instance { get { return instance; } }
	}

	internal class MagicShop:CityLocation
	{
		private static readonly MagicShop instance = new MagicShop();

		static MagicShop(){}
		private MagicShop():base("Ye Olde Magick Shoppe"){}
		public static MagicShop Instance { get { return instance; } }
	}
}
/*
Arkham Asylum 	Downtown 	Stable Location 	Clue 	Sanity 	
Bank of Arkham 	Downtown 	Stable Location 	Blessing 	Money 	
Black Cave 	Rivertown 	Unstable Location 	Common Item 	Spell 	
Curiositie Shoppe 	Northside 	Stable Location 	Common Item 	Unique Item 	
General Store 	Rivertown 	Stable Location 	Common Item 	Money 	
Graveyard 	Rivertown 	Unstable Location 	Clue 	Unique Item 	
Hibb's Roadhouse 	Easttown 	Unstable Location 	Common Item 	Money 	
Historical Society 	Southside 	Unstable Location 	Skill 	Spell 	
Independence Square 	Downtown 	Unstable Location 	Clue 	Unique Item 	
Inner Sanctum 	French Hill 	N/A 	N/A 	N/A 	
Ma's Boarding House 	Southside 	Stable Location 	Ally 	Stamina 	
Newspaper 	Northside 	Stable Location 	Clue 	Money 	
Police Station 	Easttown 	Stable Location 	Clue 	Common Item 	
River Docks 	Merchant District 	Stable Location 	Common Item 	Money 	
Silver Twilight Lodge 	French Hill 	Unstable Location 	Clue 	Unique Item 	
South Church 	Southside 
The Unnamable 	Merchant District 
The Witch House 	French Hill 
Train Station 	Northside
Unvisited Isle 	Merchant District 
Velma's Diner 	Easttown
*/