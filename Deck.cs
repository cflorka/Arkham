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

		public void Shuffle()
		{
			RuffleShuffle();
			RuffleShuffle();
			RuffleShuffle();
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

		public T Draw()
		{
		var card = cards.First.Value;
		cards.RemoveFirst();
		return card;
		}

		public T DrawBottom()
		{
			var card = cards.Last.Value;
			cards.RemoveLast();
			return card;
		}

		public void Add(T card){cards.AddFirst(card);}
		public void AddToBottom(T card){cards.AddLast(card);}
		public T TopCard{get{return cards.First.Value;}}
		public T BottomCard{get{return cards.Last.Value;}}
		public int Count{get{return cards.Count;}}
		public bool IsEmpty(){return cards.Count == 0;} 
	}
}