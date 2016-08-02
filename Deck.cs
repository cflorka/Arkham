using System;
using System.Collections.Generic;

namespace Arkham
{
	public class Deck<T>
	{
		private static Random random = new Random();
		private LinkedList<T> cards;

		internal Deck()
		{
			cards = new LinkedList<T>();
		}

		internal Deck(List<T> list)
		{
			cards = new LinkedList<T>(list);
		}

		internal void Shuffle()
		{
			RuffleShuffle();
			RuffleShuffle();
			RuffleShuffle();
		}

		private void RuffleShuffle()
		{
			Deck<T> temp = new Deck<T>();
			int count = Count;
			T current;
			for(int i = 0; i < count; ++i)
			{
				if(random.Next() % 2 == 0) current = Draw();
				else current = DrawBottom();
				if(random.Next() % 2 == 0) temp.Add(current);
				else temp.AddToBottom(current);
			}
			this.cards = new LinkedList<T>(temp.cards);
		}

		internal T Draw()
		{
		var card = cards.First.Value;
		cards.RemoveFirst();
		return card;
		}

		internal T DrawBottom()
		{
			var card = cards.Last.Value;
			cards.RemoveLast();
			return card;
		}

		internal void Add(T card){cards.AddFirst(card);}
		internal void AddToBottom(T card){cards.AddLast(card);}
		internal T TopCard{get{return cards.First.Value;}}
		internal T BottomCard{get{return cards.Last.Value;}}
		internal int Count{get{return cards.Count;}}
		internal bool IsEmpty(){return cards.Count == 0;} 
	}
}