using System.Collections.Generic;

namespace Arkham
{
	internal abstract class Card
	{
		private string title;
		private string body;
		
		internal Card(string title, string body)
		{
			this.title = title;
			this.body = body;
		}

		public override string ToString()
		{
			return title;
		}

		internal abstract void Discard();
	}
}