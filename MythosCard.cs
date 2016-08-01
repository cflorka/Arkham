using System.Collections.Generic;

namespace Arkham
{
	internal class Mythos : Card
	{
		List<Shape> whiteShapes, blackShapes;
		CityLocation gateLocation, clueLocation;

		internal Mythos(string title, string body,
			CityLocation gateLocation, CityLocation clueLocation,
			IEnumerable<Shape> whiteShapes, IEnumerable<Shape> blackShapes)
		:base(title, body)
		{
			this.gateLocation = gateLocation;
			this.clueLocation = clueLocation;
			this.whiteShapes = new List<Shape>(whiteShapes);
			this.blackShapes = new List<Shape>(blackShapes);
		}

		internal void Resolve()
		{
			//OpenGate and Spawn monster
			//PlaceClueToken
			//MoveMonsters
			//ActiveMythosAbility
		}
	}

	internal enum EnvironmentType{Mystic, Urban, Weather}
	internal class Environment : Mythos
	{
		EnvironmentType type;

		internal Environment(string title, EnvironmentType type, string body,
			CityLocation gateLocation, CityLocation clueLocation,
			IEnumerable<Shape> whiteShapes, IEnumerable<Shape> blackShapes)
		:base(title, body, gateLocation, clueLocation, whiteShapes, blackShapes)
		{
			this.type = type;
		}

		internal EnvironmentType Type{get{return type;}}

		internal void Effect(){}
	}

	internal class Rumor : Mythos
	{
		internal Rumor(string title, string body,
			CityLocation gateLocation, CityLocation clueLocation,
			IEnumerable<Shape> whiteShapes, IEnumerable<Shape> blackShapes)
		:base(title, body, gateLocation, clueLocation, whiteShapes, blackShapes){}

		internal void Pass(){}
		internal void Fail(){}
	}

	internal class Headline : Mythos
	{
		internal Headline(string title, string body,
			CityLocation gateLocation, CityLocation clueLocation,
			IEnumerable<Shape> whiteShapes, IEnumerable<Shape> blackShapes)
		:base(title, body, gateLocation, clueLocation, whiteShapes, blackShapes){}
	}
}