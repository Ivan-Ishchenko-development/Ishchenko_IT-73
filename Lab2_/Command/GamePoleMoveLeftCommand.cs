using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    class GamePoleMoveLeftCommand : ICommand
    {
        GamePole GamePole;
        public GamePoleMoveLeftCommand(GamePole b)
        {
            GamePole = b;
        }

        public void execute()
        {
            this.GamePole.MoveLeft();
        }

        public void undo()
        {
            
        }
    }
}
