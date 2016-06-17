namespace Arkham
{
	public class Location
	{
		string name;
		List<Location> connectedLocations;
		List<Investigator> investigators;
		List<Monster> monsters;
		//ToDo clueTokens/events
		internal Location(string name, List<Location> connectedLocations)
		{
			this.name = name;
			this.connectedLocations = connectedLocations
		}
		internal void add(Investigator i){investigators.add(i);}
		internal void add(Monster m){monsters.add(m);}
	}

	public class ArkhamLocation:Location
	{
		Location blackArrow, whiteArrow;
		internal ArkhamLocation(string name, List<Location> connectedLocations,
			Location blackArrow, Location whiteArrow)
			:base(name, connectedLocations)
		{
			this.blackArrow = blackArrow;
			this.whiteArrow = whiteArrow;
		}
	}

	public class CityLocation:ArkhamLocation
	{
		Street connectedStreet;
		Gate gate;
		
		internal ArkhamLocation(string name, Street street)
			:base(name, new List<Location> {street}, street, street)
		{
			connectedStreet = street;
		}
	}
	
	public class Street:ArkhamLocation
	{
		internal Street(string name, List<Location> connectedLocations,
			Location blackArrow, Location whiteArrow)
			:base(name, connectedLocations, blackArrow, whiteArrow)
	}
}
