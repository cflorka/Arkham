namespace Arkham
{
	public class Location
	{
		string name;
		List<Investigator> investigators;
		List<Monster> monsters;
		//ToDo clueTokens/events
		internal Location(string name)
		{
			this.name = name;
		}
		internal void add(Investigator i){investigators.add(i);}
		internal void add(Monster m){monsters.add(m);}
		internal List<Location> connectedLocations{ get; set;}
	}

	public class ArkhamLocation:Location
	{
		internal ArkhamLocation(string name):base(name){}

		internal Location blackLocation{ get; set; }
		internal Location whiteLocation{ get; set; }
	}

	public class CityLocation:ArkhamLocation
	{
		internal ArkhamLocation(string name):base(name){}

		internal Street connectedStreet{ get; set; }
		internal Gate openGate{ get; set; }
	}
	
	public class Street:ArkhamLocation
	{
		internal Street(string name, List<Location> connectedLocations,
			Location blackArrow, Location whiteArrow)
			:base(name, connectedLocations, blackArrow, whiteArrow)
	}
}
