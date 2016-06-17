namespace Arkham
{
	internal class MiskatonicU:Street
	{
		private static readonly MiskatonicU instance = new MiskatonicU();

		static MiskatonicU(){}
		private MiskatonicU():base("Miskatonic University")
		{
		}

		public static MiskatonicU Instance { get { return instance; } }
	}

	internal class AdminBuilding:CityLocation
	{
		private static readonly AdminBuilding instance = new AdminBuilding();

		static AdminBuilding(){}
		private AdminBuilding():base("Administration Building")
		{
		}

		public static AdminBuilding Instance { get { return instance; } }
	}

	internal class ScienceBuilding:CityLocation
	{
		private static readonly ScienceBuilding instance = new ScienceBuilding();

		static ScienceBuilding(){}
		private ScienceBuilding():base("Science Building")
		{
		}

		public static ScienceBuilding Instance { get { return instance; } }
	}

	internal class Library:CityLocation
	{
		private static readonly Library instance = new Library();

		static Library(){}
		private Library():base("Library")
		{
		}

		public static Library Instance { get { return instance; } }
	}
}
/*
Library Miskatonic University
Science Building Miskatonic University
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
St. Mary's Hospital 	Uptown 
The Unnamable 	Merchant District 
The Witch House 	French Hill 
Train Station 	Northside
Unvisited Isle 	Merchant District 
Velma's Diner 	Easttown
Woods 	Uptown
Ye Olde Magick Shoppe 	Uptown
*/