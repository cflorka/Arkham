using System;
using System.Collections.Generic;

namespace Arkham
{
	internal class PlayGame
	{
		GameBoard board = new GameBoard();
		bool gameOver = false;

		public PlayGame()
		{
		}

		public void Run()
		{
			int count = 0;
			Phase currentPhase = Phases.Current();
			while(!gameOver && count < 30)
			{
                Phase.PhaseStartHandler psh = new Phase.PhaseStartHandler(() => {Console.WriteLine("FYEAH!!!");});
                currentPhase.PhaseStart += psh;
				gameOver = currentPhase.Run(board.Investigators);
				currentPhase = Phases.Next();
				++count;
			}
		}
	}
}