using System;

namespace Arkham
{
	internal class MichaelMcGlen:Investigator
	{
		internal MichaelMcGlen():
			base("Michael McGlen", new int[2]{7, 7}, new int[2]{3, 3}, new int[2]{1, 1}, 2, 4, 3, 4, 0, 3)
		{
		}

		public override void takeDamage(int dam)
		{
			base.takeDamage(Math.Max(dam - 1, 0));
		}
	}
}