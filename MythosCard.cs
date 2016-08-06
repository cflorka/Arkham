using System.Collections.Generic;

namespace Arkham
{
	internal class MythosCard : Card
	{
		List<Shape> whiteShapes, blackShapes;
		CityLocation gateLocation, clueLocation;

		internal MythosCard(string title, string body,
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

		internal override void Discard() {Decks.Mythos.AddToBottom(this);}
	}

	internal enum EnvironmentType{Mystic, Urban, Weather}
	internal class Environment : MythosCard
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

	internal class Rumor : MythosCard
	{
		internal Rumor(string title, string body,
			CityLocation gateLocation, CityLocation clueLocation,
			IEnumerable<Shape> whiteShapes, IEnumerable<Shape> blackShapes)
		:base(title, body, gateLocation, clueLocation, whiteShapes, blackShapes){}

		internal void Pass(){}
		internal void Fail(){}
	}

	internal class Headline : MythosCard
	{
		internal Headline(string title, string body,
			CityLocation gateLocation, CityLocation clueLocation,
			IEnumerable<Shape> whiteShapes, IEnumerable<Shape> blackShapes)
		:base(title, body, gateLocation, clueLocation, whiteShapes, blackShapes){}
	}
}
