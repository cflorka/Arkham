using System;
using System.Collections.Generic;

namespace Arkham
{
    internal class PlayGame
    {
        GameBoard board = new GameBoard();
        bool gameOver = false;
        int turnCount = 0;
        
        public PlayGame()
        {
            Phases.Subscribe(MythosPhase.Instance, new Phase.PhaseEndHandler(EndTurn));
        }

        public GameBoard Board{ get{ return board; } }
        public void Run()
        {
            Phase currentPhase = Phases.Current();
            while(!gameOver && turnCount < 30)
            {
                gameOver = currentPhase.Run(board.Investigators);
                currentPhase = Phases.Next();
            }
        }

        private void EndTurn()
        {
            turnCount++;
            Console.WriteLine("Turn " + turnCount + " has ended.");
        }

    }
}