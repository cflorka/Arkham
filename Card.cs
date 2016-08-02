using System.Collections.Generic;

namespace Arkham
{
	internal class Card
	{
		string title;
		string body;
		
		internal Card(string title, string body)
		{
			this.title = title;
			this.body = body;
		}
		
		public override string ToString()
		{
			return title;
		}
	}
}