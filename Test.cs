using System;
using System.Collections.Generic;

namespace Arkham
{
	static class Test
	{
		public static void Main()
		{
			GameBoard gb = new GameBoard();
			Investigator player1 = gb.Investigators[0];
			//player1.MoveTo(Southside.Instance);
			//player1.MoveTo(Uptown.Instance);
			player1.MoveTo(FrenchHill.Instance);
			Monster bat = new Monster("Bat", Shape.Circle, MovementType.Flying, -1, -1, 3, -1, 2, 1);
			gb.Add(bat, MercDistrict.Instance);
			//Encounter.MonsterEncounter(player1, bat);
			//player1.NewTurn();
			//player1.MoveTo(MercDistrict.Instance);
			//player1.MoveTo(Northside.Instance);
			//player1.MoveTo(Newspaper.Instance);
			//gb.openGate(Newspaper.Instance);
			//gb.openGate(Newspaper.Instance);
			//player1.ChangeLocationTo(Newspaper.Instance);
			//player1.CloseGate();
			//player1.NewTurn();
			//player1.MoveTo(MercDistrict.Instance);
			gb.MoveOn(Shape.Circle, ArrowColor.Black);
			gb.MoveOn(Shape.Circle, ArrowColor.Black);
			Deck<Mythos> mythosDeck = new Deck<Mythos>(MythosDeck.List);
			mythosDeck.Shuffle();
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
		}
	}
}
