using System;
using System.Collections.Generic;

namespace Arkham
{
	static class Test
	{
        
		static PlayGame game = new PlayGame();
		static GameBoard gb = game.Board;
		static Investigator player1 = gb.Investigators[0];
		static Investigator player2 = gb.Investigators[1];
		static Monster bat = new Monster("Bat", Shape.Circle, MovementType.Flying, -1, -1, 3, -1, 2, 1);

		public static void Main()
		{
			//TestGate();
			//player1.Curse();
			//player1.Bless();
			//TestMonsterEncounter(player1, bat);
			//TestInvestigatorMovement(player1);
			//TestMonsterMovement(bat);
			//TestMythos(gb.MythosDeck);
			//TestInvestigatorsWhere();
			TestPhases();
		}

		public static void TestMonsterEncounter(Investigator investigator, Monster mon)
		{
			Encounter.MonsterEncounter(investigator, mon);
		}

		public static void TestInvestigatorMovement(Investigator investigator)
		{
			investigator.MoveTo(Southside.Instance);
			investigator.MoveTo(Uptown.Instance);
			investigator.MoveTo(FrenchHill.Instance);
			investigator.NewTurn();
			investigator.MoveTo(MercDistrict.Instance);
			investigator.MoveTo(Northside.Instance);
			investigator.MoveTo(Newspaper.Instance);
			investigator.NewTurn();
			investigator.MoveTo(MercDistrict.Instance);
			investigator.MoveTo(MiskatonicU.Instance);
		}

		public static void TestMonsterMovement(Monster mon)
		{
			gb.Add(mon, MercDistrict.Instance);
			gb.MoveOn(Shape.Circle, ArrowColor.Black);
			gb.MoveOn(Shape.Circle, ArrowColor.Black);
		}

		public static void TestMythos(Deck<MythosCard> mythosDeck)
		{
			mythosDeck.Shuffle();
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
			System.Console.WriteLine("Drew " + mythosDeck.Draw().ToString());
		}

		public static void TestGate()
		{
			Location startLoc = player1.Location;
			player1.ChangeLocationTo(Newspaper.Instance);
			gb.openGate(Newspaper.Instance);
			player1.ChangeLocationTo(Newspaper.Instance);
			gb.openGate(Newspaper.Instance);
			player1.ChangeLocationTo(Newspaper.Instance);
			player1.CloseGate();
			player1.ChangeLocationTo(startLoc);
		}

		public static void TestInvestigatorsWhere()
		{
			player1.ChangeLocationTo(MiskatonicU.Instance);
			List<Investigator> list = gb.InvestigatorsWhere(i => i.Location is Street);
			foreach(Investigator i in list)
			{
				Console.WriteLine(i.Location);
			}
		}

		public static void TestPhases()
		{
			Phases.Subscribe(UpkeepPhase.Instance, new Phase.PhaseStartHandler(player1.PhaseSignature));
			Phases.Subscribe(MythosPhase.Instance, new Phase.PhaseStartHandler(player1.PhaseSignature));
			Phases.Subscribe(CityPhase.Instance, new Phase.PhaseStartHandler(player1.PhaseSignature));
			Phases.Subscribe(MovementPhase.Instance, new Phase.PhaseStartHandler(player2.PhaseSignature));
			Phases.Subscribe(OtherWorldPhase.Instance, new Phase.PhaseStartHandler(player1.PhaseSignature));
			Phase cur = new UpkeepPhase();
			Console.WriteLine(cur.ToString());
			game.Run();
		}
	}
}
