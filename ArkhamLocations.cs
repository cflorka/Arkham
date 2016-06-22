namespace Arkham
{
	internal class MiskatonicU:Street
	{
		private static readonly MiskatonicU instance = new MiskatonicU();
		static MiskatonicU(){}
		private MiskatonicU():base("Miskatonic University"){}
		internal static MiskatonicU Instance { get { return instance; } }
	}

	internal class AdminBuilding:CityLocation
	{
		private static readonly AdminBuilding instance = new AdminBuilding();
		static AdminBuilding(){}
		private AdminBuilding():base("Administration Building"){}
		internal static AdminBuilding Instance { get { return instance; } }
	}

	internal class ScienceBuilding:CityLocation
	{
		private static readonly ScienceBuilding instance = new ScienceBuilding();
		static ScienceBuilding(){}
		private ScienceBuilding():base("Science Building"){}
		internal static ScienceBuilding Instance { get { return instance; } }
	}

	internal class Library:CityLocation
	{
		private static readonly Library instance = new Library();
		static Library(){}
		private Library():base("Library"){}
		internal static Library Instance { get { return instance; } }
	}
/////
	internal class Uptown:Street
	{
		private static readonly Uptown instance = new Uptown();
		static Uptown(){}
		private Uptown():base("Uptown"){}
		internal static Uptown Instance { get { return instance; } }
	}

	internal class Hospital:CityLocation
	{
		private static readonly Hospital instance = new Hospital();
		static Hospital(){}
		private Hospital():base("St. Mary's Hospital"){}
		internal static Hospital Instance { get { return instance; } }

/*
		internal class Heal:Encounter
		{
			System.Console.WriteLine("F)ull heal or P)artial?");
		}
*/
	}

	internal class Woods:CityLocation
	{
		private static readonly Woods instance = new Woods();
		static Woods(){}
		private Woods():base("Woods"){}
		internal static Woods Instance { get { return instance; } }
	}

	internal class MagicShop:CityLocation
	{
		private static readonly MagicShop instance = new MagicShop();
		static MagicShop(){}
		private MagicShop():base("Ye Olde Magick Shoppe"){}
		internal static MagicShop Instance { get { return instance; } }
	}
/////
	internal class MercDistrict:Street
	{
		private static readonly MercDistrict instance = new MercDistrict();
		static MercDistrict(){}
		private MercDistrict():base("Mercant District"){}
		internal static MercDistrict Instance { get { return instance; } }
	}

	internal class Unnamable:CityLocation
	{
		private static readonly Unnamable instance = new Unnamable();
		static Unnamable(){}
		private Unnamable():base("The Unnamable"){}
		internal static Unnamable Instance { get { return instance; } }
	}

	internal class Docks:CityLocation
	{
		private static readonly Docks instance = new Docks();
		static Docks(){}
		private Docks():base("River Docks"){}
		internal static Docks Instance { get { return instance; } }
	}

	internal class UnvisitedIsle:CityLocation
	{
		private static readonly UnvisitedIsle instance = new UnvisitedIsle();
		static UnvisitedIsle(){}
		private UnvisitedIsle():base("Unvisited Isle"){}
		internal static UnvisitedIsle Instance { get { return instance; } }
	}
/////
	internal class Northside:Street
	{
		private static readonly Northside instance = new Northside();
		static Northside(){}
		private Northside():base("Northside"){}
		internal static Northside Instance { get { return instance; } }
	}

	internal class Newspaper:CityLocation
	{
		private static readonly Newspaper instance = new Newspaper();
		static Newspaper(){}
		private Newspaper():base("Newspaper"){}
		internal static Newspaper Instance { get { return instance; } }
	}

	internal class TrainStation:CityLocation
	{
		private static readonly TrainStation instance = new TrainStation();
		static TrainStation(){}
		private TrainStation():base("Train Station"){}
		internal static TrainStation Instance { get { return instance; } }
	}

	internal class CurioShop:CityLocation
	{
		private static readonly CurioShop instance = new CurioShop();
		static CurioShop(){}
		private CurioShop():base("Curiositie Shoppe"){}
		internal static CurioShop Instance { get { return instance; } }
	}
/////
	internal class Downtown:Street
	{
		private static readonly Downtown instance = new Downtown();
		static Downtown(){}
		private Downtown():base("Downtown"){}
		internal static Downtown Instance { get { return instance; } }
	}

	internal class Asylum:CityLocation
	{
		private static readonly Asylum instance = new Asylum();
		static Asylum(){}
		private Asylum():base("Arkham Asylum"){}
		internal static Asylum Instance { get { return instance; } }
	}

	internal class Bank:CityLocation
	{
		private static readonly Bank instance = new Bank();
		static Bank(){}
		private Bank():base("Bank of Arkham"){}
		internal static Bank Instance { get { return instance; } }
	}

	internal class IndependenceSq:CityLocation
	{
		private static readonly IndependenceSq instance = new IndependenceSq();
		static IndependenceSq(){}
		private IndependenceSq():base("Independence Square"){}
		internal static IndependenceSq Instance { get { return instance; } }
	}
/////
	internal class Easttown:Street
	{
		private static readonly Easttown instance = new Easttown();
		static Easttown(){}
		private Easttown():base("Easttown"){}
		internal static Easttown Instance { get { return instance; } }
	}

	internal class PoliceStation:CityLocation
	{
		private static readonly PoliceStation instance = new PoliceStation();
		static PoliceStation(){}
		private PoliceStation():base("Police Station"){}
		internal static PoliceStation Instance { get { return instance; } }
	}

	internal class Roadhouse:CityLocation
	{
		private static readonly Roadhouse instance = new Roadhouse();
		static Roadhouse(){}
		private Roadhouse():base("Hibb's Roadhouse"){}
		internal static Roadhouse Instance { get { return instance; } }
	}

	internal class Diner:CityLocation
	{
		private static readonly Diner instance = new Diner();
		static Diner(){}
		private Diner():base("Velma's Diner"){}
		internal static Diner Instance { get { return instance; } }
	}
/////
	internal class Rivertown:Street
	{
		private static readonly Rivertown instance = new Rivertown();
		static Rivertown(){}
		private Rivertown():base("Rivertown"){}
		internal static Rivertown Instance { get { return instance; } }
	}

	internal class GenStore:CityLocation
	{
		private static readonly GenStore instance = new GenStore();
		static GenStore(){}
		private GenStore():base("General Store"){}
		internal static GenStore Instance { get { return instance; } }
	}

	internal class Graveyard:CityLocation
	{
		private static readonly Graveyard instance = new Graveyard();
		static Graveyard(){}
		private Graveyard():base("Graveyard"){}
		internal static Graveyard Instance { get { return instance; } }
	}

	internal class Cave:CityLocation
	{
		private static readonly Cave instance = new Cave();
		static Cave(){}
		private Cave():base("Black Cave"){}
		internal static Cave Instance { get { return instance; } }
	}
/////
	internal class FrenchHill:Street
	{
		private static readonly FrenchHill instance = new FrenchHill();
		static FrenchHill(){}
		private FrenchHill():base("French Hill"){}
		internal static FrenchHill Instance { get { return instance; } }
	}

	internal class Lodge:CityLocation
	{
		private static readonly Lodge instance = new Lodge();
		static Lodge(){}
		private Lodge():base("Silver Twilight Lodge"){}
		internal static Lodge Instance { get { return instance; } }
	} //Add "Inner Sanctum" logic

	internal class WitchHouse:CityLocation
	{
		private static readonly WitchHouse instance = new WitchHouse();
		static WitchHouse(){}
		private WitchHouse():base("The Witch House"){}
		internal static WitchHouse Instance { get { return instance; } }
	}
/////
	internal class Southside:Street
	{
		private static readonly Southside instance = new Southside();
		static Southside(){}
		private Southside():base("Southside"){}
		internal static Southside Instance { get { return instance; } }
	}

	internal class HistSociety:CityLocation
	{
		private static readonly HistSociety instance = new HistSociety();
		static HistSociety(){}
		private HistSociety():base("Historical Society"){}
		internal static HistSociety Instance { get { return instance; } }
	}

	internal class BoardHouse:CityLocation
	{
		private static readonly BoardHouse instance = new BoardHouse();
		static BoardHouse(){}
		private BoardHouse():base("Ma's Boarding House"){}
		internal static BoardHouse Instance { get { return instance; } }
	}

	internal class Church:CityLocation
	{
		private static readonly Church instance = new Church();
		static Church(){}
		private Church():base("South Church"){}
		internal static Church Instance { get { return instance; } }
	}

	internal class Sky:Location
	{
		private static readonly Sky instance = new Sky();
		static Sky(){}
		private Sky():base("Sky"){}
		internal static Sky Instance { get { return instance; } }
	}

	internal class Outskirts:Location
	{
		private static readonly Outskirts instance = new Outskirts();
		static Outskirts(){}
		private Outskirts():base("Outskirts"){}
		internal static Outskirts Instance { get { return instance; } }
	}

	internal class LostInTime:Location
	{
		private static readonly LostInTime instance = new LostInTime();
		static LostInTime(){}
		private LostInTime():base("Lost in Time and Space"){}
		internal static LostInTime Instance { get { return instance; } }
	}
}