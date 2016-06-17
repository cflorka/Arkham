using System;

namespace Arkham
{
	internal class MichaelMcGlen:Investigator
	{
		private static readonly MichaelMcGlen instance = new MichaelMcGlen();

		static MichaelMcGlen(){}
		private MichaelMcGlen():
			base("Michael McGlen", new int[2]{3, 3}, new int[2]{7, 7}, new int[2]{1, 1}, new int[3]{1, 1, 1}, 2, 4, 3, 4, 0, 3)
		{
			//$8
			//Dynamite (common), Tommy Gun(common)
			//1 Unique Item
			//1 Skill
			//ToDo: StartingLocation: Ma's Boarding Home
		}

		public static MichaelMcGlen Instance{ get { return instance; } }

		public override void takeDamage(int dam)
		{
			base.takeDamage(Math.Max(dam - 1, 0));
		}
	}

	internal class BobJenkins:Investigator
	{
		private static readonly BobJenkins instance = new BobJenkins();

		static BobJenkins(){}
		private BobJenkins():
			base("Bob Jenkins", new int[2]{4, 4}, new int[2]{6, 6}, new int[2]{1, 1},
				new int[3]{1, 1, 1}, 2, 3, 1, 6, 0, 4)
		{
			//$9
			//drawCommon(2)
			//drawUnique(2)
			//drawSkill(1)
			//ToDo: Set starting location: General Store
		}

		public static BobJenkins Instance{get{return instance;}}

		//ToDo: Power (common draw + 1, discard one)
	}
	
	public sealed class KateWinthrop:Investigator
	{
		private static readonly KateWinthrop instance = new KateWinthrop();

		static KateWinthrop(){}
		private KateWinthrop()
			:base("Kate Winthrop", new int[2]{6, 6}, new int[2]{4, 4}, new int[2]{1, 1},
				new int[3]{1, 1, 1}, 1, 5, 1, 3, 2, 4)
		{
			//$7
			//2 Clue Tokens
			//drawCommon(1)
			//drawUnique(1)
			//drawSpell(2)
			//drawSkill(1)
		}
		
		//ToDo: Power (no monsters or gates can appear in same location)

		public static KateWinthrop Instance { get { return instance; } }

	} 
}